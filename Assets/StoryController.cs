using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StoryController : MonoBehaviour
{
    public GameObject title;
    public GameObject credits;
    public GameObject creds;
    public GameObject dialogue;
    public GameObject button01;
    public GameObject button02;

    private int counter;
    private int buttonCounter01;
    private int buttonCounter02;
    private int c;
    private bool smile;
    private bool alli;
    private bool jack;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        buttonCounter01 = 0;
        buttonCounter02 = 0;
        c = 650;
        smile = false;
        alli = false;
        jack = false;

        Section00();

        // Debug
        // counter = 9;
        // credits.SetActive(true);
        // creds.GetComponent<TextMeshProUGUI>().text = "" + c;
        // button02.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Exit();

        Section01();
        Section02();
        Section03();
        Section04();
        Section05();
        Section06();
        Section07();
        Section08();
        Section09();
        Section10();
        Section11();
    }

    public void ButtonClick(int button)
    {
        if (button == 1)
        {
            buttonCounter01++;
        }
        else
        {
            buttonCounter02++;
        }
    }

    private void Exit()
    {
        if (counter == 0 && buttonCounter02 == 1)
        {
            Application.Quit();
        }

        if (counter == 10 && buttonCounter02 == 1)
        {
            Application.Quit();
        }
    }

    private void Credit(int cr)
    {
        c += cr;

        if (c < 0)
        {
            c = 0;
        }

        if (c > 1000)
        {
            c = 1000;
        }

        creds.GetComponent<TextMeshProUGUI>().text = "" + c;
    }

    private void Section00()
    {
        title.GetComponent<TextMeshProUGUI>().text = "Smart World";
        credits.SetActive(false);
        dialogue.GetComponent<TextMeshProUGUI>().text = "Mitchell Roger Marshe\n\nDecember 9, 2019";
        button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
        button02.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Exit";
    }

    private void Section01()
    {
        if (counter == 0)
        {
            if (buttonCounter01 == 1) {
                button02.SetActive(false);
                title.GetComponent<TextMeshProUGUI>().text = "I: The Factory";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "\"Sales are everywhere this Black Friday! Don’t miss out on getting a new Holo-TV. " +
                    "I know, I will be in line,\" announces the brunet lady over the holographic display " +
                    "mounted in the corner of the breakroom. The blue lit holographic TV flickered as an " +
                    "advertisement started to appear. \"Get the all-new 2048 Vesba LX Sedan for $24,999.99. " +
                    "The car that drives for you! Qualified buyers must have a\" – a factory whistle interrupts " +
                    "the sound – \"or higher,\" exclaims a voiceover man with enthusiasm.";
            }

            if (buttonCounter01 == 2)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "\"Nick, come on! Breaktime is over.\"";
            }

            if (buttonCounter01 == 3)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "\"I’m coming, Walter.\"";
            }

            if (buttonCounter01 == 4)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I caught up with Walter down a white corridor that lead to double doors. Beyond the doors, machinery " +
                    "and people shouting could be heard. The doors remain locked until Walter passed his hands through a " +
                    "sensor that picked up his electronic wristband. A robotic voice emerges: \"Walter Ziez clocked in at " +
                    "1:00 PM, Friday, November 29, 2048.\" I followed suit. \"Nick Strayport clocked in at 1:01 PM, Friday, " +
                    "November 29, 2048,\" responds a robotic voice from the sensor. Walter and I walked through the doors and " +
                    "onto the factory floor.";
            }

            if (buttonCounter01 == 5)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “We got to make pace. You know how They are here at ShipAway. " +
                    "They’ve been deducting our Creds for slow progress.”";
            }

            if (buttonCounter01 == 6)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I know. Shits real fucked- up. I’m barely holding onto good Cred.”";
            }

            if (buttonCounter01 == 7)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “I feel ya, Nick. My wife been bugging me about keeping up with Cred. " +
                    "She wants a new a car.”";
            }

            if (buttonCounter01 == 8)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “You need decent Cred – at least. Ugh! Our Unity Bands are blinking. " +
                    "We better hurry up and get to bay 57. I swear ShipAway keeps getting bigger and bigger.\"";
            }

            if (buttonCounter01 == 9)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “More demanding… you mean.”";
            }

            if (buttonCounter01 == 10)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "We steadily made our way to bay 57. Here we package up things that people " +
                    "bought online. Each packer is expected to ship out an item every 30 seconds or less. If we don’t make that kind of " +
                    "progress, we get deducted Creds. You’ll know if Creds are being affected if the Unity Band glows. It’s an annoying " +
                    "device that’s wrapped around our wrist constantly.";

                credits.SetActive(true);
                creds.GetComponent<TextMeshProUGUI>().text = "" + c;
            }

            if (buttonCounter01 == 11)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “Pay attention Nick! Pass me the package.”";
                button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Pass Walter the package";
                button02.SetActive(true);
                button02.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue to zone out";
            }

            if (buttonCounter02 != 1)
            {
                if (buttonCounter01 == 12)
                {
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);

                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Sorry. I was zoning out. It’s been hours of pushing all this product out.”";
                }

                if (buttonCounter01 == 13)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “It’s a busy week of holidays!”";
                }

                if (buttonCounter01 == 14)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Yeah… I know. Too bad, I’m not enjoying it!”";
                }

                if (buttonCounter01 == 15)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Several hours passed by. A final factory whistle blew.";
                }

                if (buttonCounter01 == 16)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Finally, we’re done for the week. I’ll see you on Monday.”";
                }

                if (buttonCounter01 == 17)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “Until then, friend.”";
                }

                if (buttonCounter01 == 18)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "My Unity Band glowed, I could see a raise in Creds. A job well done. I love working with Walter. " +
                        "He’s been my friend for the last two years since I joined ShipAway. Sometimes, we go out for drinks " +
                        "at the local bar. Other times, I’ll show up invited to his house. Usually to have a barb-a-que. Well, " +
                        "it’s time to head home.";
                    Credit(10);
                    buttonCounter01++;
                }

                if (buttonCounter01 == 20)
                {
                    counter++;
                    buttonCounter01 = 0;
                    buttonCounter02 = 0;
                }
            }
            else
            {
                if (buttonCounter01 == 11) {
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    buttonCounter01++;
                }

                if (buttonCounter01 == 12)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “Nick? Hello?”";
                }

                if (buttonCounter01 == 13)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "My Unity Band glowed, I could see a decrease of Creds. I was slipping up on the job.";
                    Credit(-2);
                    buttonCounter01++;
                }

                if (buttonCounter01 == 15)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Oh shit. Sorry! Here is the package.”";
                }

                if (buttonCounter01 == 16)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “Keep up, we got orders to fulfil. My wife is gonna want that car!”";
                }

                if (buttonCounter01 == 17)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Several hours passed by. A final factory whistle blew.";
                }

                if (buttonCounter01 == 18)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Finally, we’re done for the week. I’ll see you on Monday.”";
                }

                if (buttonCounter01 == 19)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Walter: “Until then, friend.”";
                }

                if (buttonCounter01 == 20)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "What a hectic day. Lost some Creds too. At least I was with Walter. He’s been my friend for the last " +
                        "two years since I joined ShipAway. Sometimes, we go out for drinks at the local bar. Other times, " +
                        "I’ll show up invited to his house. Usually to have a barb-a-que. Well, it’s time to head home.";
                    Credit(-8);
                    buttonCounter01++;
                }

                if (buttonCounter01 == 22)
                {
                    counter++;
                    buttonCounter01 = 0;
                    buttonCounter02 = 0;
                }
            }
        }
    }

    private void Section02()
    {
        if (counter == 1)
        {
            if (buttonCounter01 == 0)
            {
                title.GetComponent<TextMeshProUGUI>().text = "II: Smart World";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "“Welcome home, Nick Strayport,” announces a robotic voice from the doorway. I know my studio doesn’t look " +
                    "like much from this foyer. It’s just a room with a decent view of Citadel. I got what I need here. I’m " +
                    "just a single, average guy living in a smart world.";
            }

            if (buttonCounter01 == 1)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Towards my right is the bathroom. There’s no tub to relax in. The shower is the entire space. Water sprays " +
                    "down from the ceiling like a rain forest. The toilet makes for a good bench while lathering up soap. " +
                    "Otherwise, the toilet is just for personal business. In front of the toilet is the sink and medicine " +
                    "cabinet affixed with a mirror door.";
            }

            if (buttonCounter01 == 2)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Going beyond the foyer is the room that shifts from living room to bedroom. That couch over there on the " +
                    "left wall is where I sit and sleep. Over to the right is a blank wall until I turn on the Holo-TV. In the " +
                    "center of this space is a coffee table with a cup half-full of coffee. I love coffee. Coffee is about the " +
                    "only thing that keeps up. It appears, I spilt some coffee earlier on the concrete floor. I better get a " +
                    "paper towel from the kitchen.";
            }

            if (buttonCounter01 == 3)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Towards the back of the living room, the kitchen is sectioned off. " +
                "There’s a small bar for two. A sink centered within the bar. Slapped against the back wall are the cabinets and " +
                "appliances. I’m lucky to have a stove because most people in studios resort to tabletop burners. I don’t have a " +
                "dishwasher, but I got a decent size fridge.";
            }

            if (buttonCounter01 == 4)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text =
                    "I have enough storage for my utensils and dishware. The tall cabinet to the left of the fridge is a pantry. " +
                    "Oh yeah, I came into this kitchen to get a paper towel. I keep them on a vertical reel, situated over the bar.";
            }

            if (buttonCounter01 == 5)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I walked over to the coffee stain with some gathered paper towels. Some moist and some dry. " +
                    "I cleaned the stained concrete floor next to the coffee table. Then walked over to the waste bin " +
                    "in the kitchen. My Unity Band glowed as I gained a credit for housekeeping. Feeling relieved, I " +
                    "looked forward at the skyline of Citadel through my window.";
                Credit(1);
                buttonCounter01++;
            }

            if (buttonCounter01 == 7)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "The eyes of Citadel looked back at me. We’re constantly being watched and judged accordingly for our " +
                    "everyday actions. Glance closely at Citadel. One can see stop lights monitored by several cameras. " +
                    "These cameras police the citizens to obey traffic laws. Those who do not follow the rules of Citadel " +
                    "will be punished by the social credit system. We citizens are aware of our Creds as our Unity Bands " +
                    "notify us of our actions.";
            }

            if (buttonCounter01 == 8)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I don’t know what I’d do without my Unity Band. This electronic wristband basically runs my whole life. " +
                    "This device has my schedule laid out in a virtual calendar. I’m able to connect to social media and " +
                    "other devices out there. Basically, all electronic devices now sync with the Unity Band. Being synced " +
                    "is just the reinforcement that the Citadel government wants. They want to monitor our every move. " +
                    "Score us on proper socioeconomic behavior.";
            }

            if (buttonCounter01 == 9)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Life wasn’t like this always though. Back in 2044, there was no social credit system here in Citadel. " +
                    "Life was simply about money and acquiring what you could besides the essentials. I worked on an " +
                    "assembly line, building cell phones. Cell phones are the predecessors to the Unity Bands.";
                    
            }
            
            if (buttonCounter01 == 10)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "The pay " +
                    "at Telecom Industries was decent enough to allow me to afford a small home for a family of 4. I " +
                    "might be single now, but there was a time I wasn’t. The future of making a family was rapidly " +
                    "changing with technology and the government campaign.";
            }

            if (buttonCounter01 == 11)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "In the following year, President Clara Jaine Bells took office. She is the first female president of " +
                    "Citadel. She also campaigned for a social credit system in our region. Her party became known as the " +
                    "Creditors. Creditors are an elite group of wealthy and high moral citizens who believe in social credit " +
                    "as a mechanism to further distance themselves from common folk like me.";             
            }

            if (buttonCounter01 == 12)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "The idea behind the social credit system is to police citizens at the micro level of everyday actions. " +
                    "This would reinforce ideal citizen behavior. Those who have good social credit and money can acquire " +
                    "certain luxuries. While those who have bad social credit are barred from certain luxuries. Regardless " +
                    "of wealth.";
            }

            if (buttonCounter01 == 13)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "There’s a reason why my studio is so plain. My social credit is just “good.” I have money to afford a " +
                    "house, but not the Cred. It’s difficult gaining credibility in Citadel. Just the minor infractions " +
                    "costs 2 Creds. If I fucked up at ShipAway on a busy day, I could lose as much as 10 Creds! There’s " +
                    "only so many credits one can lose before they’re blacklisted.";
            }

            if (buttonCounter01 == 14)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Being blacklisted sucks! You can only buy food and rent a room here in Citadel while blacklisted. " +
                    "Most of your freedom is stripped away. You’re basically a criminal. Processed without trial. " +
                    "Jailed within the confines of which you already know and live. You cannot vote, take transit, own " +
                    "property, or use social media. Forget escaping Citadel, the borders require low credibility to leave.";
            }

            if (buttonCounter01 == 15)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Thankfully, I’ve maintained good Cred. I stay relatively around 620 Creds. Never have I ever been " +
                    "blacklisted. The blacklist occurs when one is below 400 Creds. I’ve seen those who have been " +
                    "blacklisted. I avoid them at all costs because being associated with black listers can hurt your " +
                    "own credit. I tend to stay around a social circle of good Creditors like Walter. Hardly do I mingle " +
                    "with decent and excellent Creditors. If you can stay around those kinds of people, credibility gets " +
                    "boosted.";
            }

            if (buttonCounter01 == 16)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "It’s late now. Time for bed. “Good night Nick Strayport,” says a robotic voice slowly dissipating from " +
                    "the glowing Unity Band. I rest my head into the pillow of the sofa.";
                buttonCounter01++;
            }

            if (buttonCounter01 == 18)
            {
                counter++;
                buttonCounter01 = 0;
                buttonCounter02 = 0;
            }
        }        
    }

    private void Section03()
    {
        if (counter == 2)
        {
            if (buttonCounter01 == 0)
            {
                title.GetComponent<TextMeshProUGUI>().text = "III: Everyday Life";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I slowly opened my eyes from a deep somber sleep. The warm light pierced through the window over " +
                    "the concrete floor, coffee table, and the sofa that I laid on. I checked my Unity Band for the time. " +
                    "Within the holographic blue light appeared the time. It’s 9:37 AM. It’s time to get ready for the day. " +
                    "I rose from the sofa.";
                button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Take a shower";
                button02.SetActive(true);
                button02.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Prepare breakfast";
            }

            if (buttonCounter02 == 0)
            {
                if (buttonCounter01 == 1)
                {
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I walked sluggishly towards the foyer and made a left into the bathroom. I undressed myself " +
                        "and threw my clothes into a hamper stored away inside a cubby hole of the restroom. Pressing " +
                        "a button on my Unity Band, I activated the shower and proceeded to bathe for the next few " +
                        "minutes. Afterwards, I brushed my teeth and dried off with a towel.";
                }

                if (buttonCounter01 == 2)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I exited the bathroom into the foyer and walked back towards the sofa. Bending over, " +
                        "I pulled out the left drawer from underneath the sofa. I retrieved clean clothes for the day. " +
                        "Then, I dressed myself.";
                }

                if (buttonCounter01 == 3)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "Next, I walked over to the kitchen. Glancing at the bar where the coffee maker with a mug " +
                        "already situated. I pressed a button on my Unity Band to brew coffee. As the coffee steamed " +
                        "out from the machine, I collected a spoon from a bar drawer and a yogurt cup from the fridge. " +
                        "I proceeded to eat the yogurt. Shortly after consuming the yogurt, the coffee was ready. " +
                        "It wasn’t long before the mug was empty by me.";
                }

                if (buttonCounter01 == 4)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "There wasn’t anything else to eat. I need to go shopping for groceries. I headed out the door " +
                        "of the studio. “See you later, Nick Strayport,” said a robotic voice the doorway.";
                    buttonCounter02++;
                }
            }
            else
            {
                if (buttonCounter01 == 0)
                {
                    smile = true;
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I walked sluggishly over to the kitchen. Glancing at the bar where the coffee maker with a mug " +
                        "already situated. I pressed a button on my Unity Band to brew coffee. As the coffee steamed out " +
                        "from the machine, I collected a spoon from a bar drawer and a yogurt cup from the fridge. I " +
                        "proceeded to eat the yogurt. Shortly after consuming the yogurt, the coffee was ready. It " +
                        "wasn’t long before the mug was empty by me. There wasn’t anything else to eat. I need to " +
                        "go shopping for groceries.";
                }

                if (buttonCounter01 == 1)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I left the kitchen and walked back towards the sofa. Bending over, I pulled out the left drawer " +
                        "from underneath the sofa. I retrieved clean clothes for the day. Then, I undressed myself. I threw " +
                        "my worn clothes across the sofa. Then, proceeded towards the foyer and walked left into the bathroom.";
                }

                if (buttonCounter01 == 2)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I placed my clean clothes into a hamper stored away inside a cubby hole of the restroom. Pressing a " +
                        "button on my Unity Band, I activated the shower and bathed for the next few minutes. Afterwards, I " +
                        "brushed my teeth, dried off with a towel, and got dressed.";
                }

                if (buttonCounter01 == 3)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I exited the bathroom into the foyer and headed out the door of the studio. “See you later, " +
                        "Nick Strayport,” said a robotic voice the doorway. It’s time to go shopping.";
                    buttonCounter02++;
                    buttonCounter01++;
                }
            }

            if (buttonCounter01 == 5)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I made my way downstairs onto the street level of Commons. People walked in all directions, " +
                    "even across stopped traffic. I wanted to hail a cab to get to the market, but it appears I’ll " +
                    "have to travel on foot. The market is a few blocks north of where I live. I began walking " +
                    "towards the market. The journey was proving to take a while with all the traffic and stops " +
                    "at crosswalks.";
                button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Jaywalk to save time";
                button02.SetActive(true);
                button02.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Obey traffic";
            }

            if (buttonCounter02 == 2)
            {
                if (buttonCounter01 == 6)
                {
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I skipped across the busy streets and before I knew it, I made it to the market. My Unity Band " +
                        "alarmed me several times. What’s a few Creds down the drain? I can’t get my life back, but I can " +
                        "get those Creds.";
                    Credit(-40);
                    buttonCounter01++;
                    buttonCounter02 = 4;
                }
            }
            else
            {
                if (buttonCounter01 == 5)
                {
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I followed traffic signals throughout the busy streets. Hours had passed by, but I made it to " +
                        "the market.";
                    buttonCounter01 = 7;
                    buttonCounter02 = 4;
                }
            }

            if (buttonCounter01 == 8)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "“Get your fresh produce!” yelled out a merchant. Looking down the busy market, I eyed for a vendor of interest. There’s an old farmer who sells some of the freshest vegetables here in the Commons. I don’t like to go to the supermarkets, buying overly modified foods grown in labs. Plus, there is less people watching us here in the market than in the corporations.";
            }

            if (buttonCounter01 == 9)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Farmer: “Oh you’re back for more?”";
            }

            if (buttonCounter01 == 10)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “It’s Saturday.”";
            }

            if (buttonCounter01 == 11)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Farmer: “Yes. What do you want this time?”";
            }

            if (buttonCounter01 == 12)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’ll take those tomatoes. These carrots, onions, and squash.”";
            }

            if (buttonCounter01 == 13)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Farmer: “Okay.”";
            }

            if (buttonCounter01 == 14)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Do you have steak available?”";
            }

            if (buttonCounter01 == 15)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Farmer: “I’m afraid not this time, but I got pork chops.”";
            }

            if (buttonCounter01 == 16)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’ll take some pork chops.”";
            }

            if (buttonCounter01 == 17)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Farmer: “That’ll be $21.37.”";
            }

            if (buttonCounter01 == 18)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "I let the farmer scan my Unity Band, the money retracted from my account.";
            }

            if (buttonCounter01 == 19)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Farmer: “Nice seeing you again!”";
            }

            if (buttonCounter01 == 20)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “You as well, sir!”";
            }

            if (buttonCounter01 == 21)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "We both rated each other with positive Cred.";
                Credit(4);
                buttonCounter01++;
            }

            if (buttonCounter01 == 23)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "As I left the farmer from the market, I began my journey back home. Being in a bit of hurry, I brushed up against a woman. She stumbled but regain composure. She was a fair lady, well dressed and looked to be going somewhere important. I quickly apologized and smiled.";
            }

            if (buttonCounter01 == 24)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’m sorry to bump you!”";
            }

            if (buttonCounter01 == 25)
            {
                if (smile)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Lady: “Please, watch where you’re going.”";
                }
                else
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Lady: “Ugh. Watch where you’re going!”";
                }
            }

            if (buttonCounter01 == 26)
            {
                if (smile)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I regained myself and made my way home cautiously. I put away the groceries I had bought. " +
                        "Took the dirty clothes off the couch and placed them in the hamper stored away in the " +
                        "bathroom. My Unity Band lit up and I gained several Creds for positive shopping and " +
                        "housekeeping habits.";
                    Credit(20);
                    buttonCounter01++;
                }
                else
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "My Unity Band lit up and I lost several Creds for disgusting the lady. People of high stature " +
                        "can easily downrate your Creds. I need to watch out more. I cautiously made my way back home " +
                        "with the groceries I bought.";
                    Credit(-20);
                    buttonCounter01++;
                }
            }

            if (buttonCounter01 == 28)
            {
                counter++;
                buttonCounter01 = 0;
                buttonCounter02 = 0;
            }
        }
    }

    private void Section04()
    {
        if (counter == 3)
        {
            if (buttonCounter01 == 0)
            {
                title.GetComponent<TextMeshProUGUI>().text = "IV: A Date";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "After going shopping, I decided to relax on the sofa and go on the dating app called Swiped. I can’t be " +
                    "single forever. Several hours had passed as I was swiping for local women. I found two potential " +
                    "matches. The first match is a 25-year-old hottie by name of Melissa. Her profile only " +
                    "said: “Ready to mingle.” While the other goes by “Alli.” She’s a 28-year-old mother of two, " +
                    "looking for something more serious in her life.";
                button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Go on a date with Melissa";
                button02.SetActive(true);
                button02.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Go on a date with Alli";
            }

            if (buttonCounter02 == 0)
            {
                if (buttonCounter01 == 1)
                {
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "The following day in the late night, I met up with Melissa at a bar. This bar was in busy " +
                        "the parts of the Lower Commons. A place full of regrets.";
                }

                if (buttonCounter01 == 2)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Melissa?”";
                }

                if (buttonCounter01 == 3)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Melissa: “Hey.”";
                }

                if (buttonCounter01 == 4)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’m Nick. Let me get us some drinks.”";
                }

                if (buttonCounter01 == 5)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Melissa: “Sounds good.”";
                }

                if (buttonCounter01 == 6)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Bartender can I two on the rocks, please.”";
                }

                if (buttonCounter01 == 7)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Bartender: “Sure thing. Open tab?”";
                }

                if (buttonCounter01 == 8)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Yeah.”";
                }

                if (buttonCounter01 == 9)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "Melissa and I shared a few drinks at the bar together. She was reluctant to give me any personal " +
                        "information. We mainly talked about classical rock music. It wasn’t long before we decided to " +
                        "hit a hotel together.";
                }

                if (buttonCounter01 == 10)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "I woke up alone in bed the next morning. I couldn’t " +
                    "remember much about Melissa. I noticed my Creds went down significantly. It appears Melissa, last " +
                    "name Vard is blacklisted. I’m guilty by association for hanging out with her. I better get ready for work.";
                    Credit(-100);
                    buttonCounter01++;
                }

                if (buttonCounter01 == 12)
                {
                    counter++;
                    buttonCounter01 = 0;
                    buttonCounter02 = 0;
                }
            }
            else
            {
                if (buttonCounter01 == 0)
                {
                    alli = true;
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "The following day in the afternoon, I met up with Alli at a coffee shop. This coffee shop was " +
                        "only 3 blocks away from my studio. The day seemed calm.";
                }

                if (buttonCounter01 == 2)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Alli?”";
                }

                if (buttonCounter01 == 3)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Alli: “Hello, Nick.”";
                }

                if (buttonCounter01 == 4)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Nice to see you here. Let me get us some drinks.”";
                }

                if (buttonCounter01 == 5)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Alli: “Sounds good.”";
                }

                if (buttonCounter01 == 6)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Can I two caramel fraps, please.”";
                }

                if (buttonCounter01 == 7)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Barista: “Coming right up!”";
                }

                if (buttonCounter01 == 8)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "Alli and I enjoyed our coffees together. We talked about our lives and ourselves. " +
                        "I came to learn more about her. Her full name is Allison Wright. She has a 7-year-old " +
                        "daughter and a 4-year-old son. She recently became divorce after dealing with a drunkard of a spouse.";
                }

                if (buttonCounter01 == 9)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "Our date became short lived though. Alli had to depart me since she her babysitter called in. " +
                        "I can’t say I’m disappointed, we did decide on a second date. I left home positively with my " +
                        "attitude and Creds.";
                    Credit(50);
                    buttonCounter01++;
                }

                if (buttonCounter01 == 11)
                {
                    counter++;
                    buttonCounter01 = 0;
                    buttonCounter02 = 0;
                }
            }
        }
    }

    private void Section05()
    {
        if (counter == 4)
        {
            if (buttonCounter01 == 0)
            {
                title.GetComponent<TextMeshProUGUI>().text = "V: Artificially ShipAway";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Arriving at ShipAway’s front gate, I notice my co-workers all riled up. They " +
                    "shouted, “We want our jobs back!” I inquired a fellow next to me.";
            }

            if (buttonCounter01 == 1)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “What’s going on here?”";
            }

            if (buttonCounter01 == 2)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Coworker: “We lost our jobs to robots!”";
            }

            if (buttonCounter01 == 3)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Nick: “What the fuck? They never said anything about this happening.”";
            }

            if (buttonCounter01 == 4)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Coworker: “It just happened!”";
            }

            if (buttonCounter01 == 5)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I left towards home angrily. I couldn’t believe I lost my job to robots. " +
                    "So many people out of work, including Walter. I didn’t even recall seeing him there.";
            }

            if (buttonCounter01 == 6)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "As the following days progressed, I steadily started losing my Creds. I began to seek to " +
                    "new employment, but no one wanted to hire me. Things were turning for the worse. I " +
                    "decided to leave Citadel, visit family before I couldn’t.";
                Credit(-40);
                buttonCounter01++;
            }

            if (buttonCounter01 == 8)
            {
                counter++;
                buttonCounter01 = 0;
                buttonCounter02 = 0;
            }
        }
    }

    private void Section06()
    {
        if (counter == 05)
        {
            if (buttonCounter01 == 0)
            {
                if (c >= 600)
                {
                    Credit(-1000);
                    Credit(512);
                }
                title.GetComponent<TextMeshProUGUI>().text = "VI: Civil War";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I spent Christmas with my parents in the countryside, just outside of Citadel. It was a nice " +
                    "time spent away from the stresses of life. No prying eyes.";
            }

            if (buttonCounter01 == 1)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Before New Year’s, chaos erupted outside the walls of Citadel. A rebellion of black listers " +
                    "and non-conformists banded together to overthrow the Creditors. Exchange of gunfire and bombs " +
                    "clearly divided the people of the nation. All of this could be seen on live television. I " +
                    "could hear the chaos closely.";
            }

            if (buttonCounter01 == 2)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I gathered my things and left towards Citadel to seek sanctuary. Carefully, I drove down the " +
                    "county side towards the gate of Citadel. Just a few a mile ahead, I could see on my far right, " +
                    "smoke billowing from the ground. The civil war wasn’t far from me.";
            }

            if (buttonCounter01 == 3)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Sanctuary was emanating as I approach the Citadel gate. A guardsman asked me to exit the " +
                    "vehicle and verify myself before entry.";
            }

            if (buttonCounter01 == 4)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Guard: “Please exit the vehicle with your hands up!”";
            }

            if (buttonCounter01 == 5)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Yes, sir.”";
            }

            if (buttonCounter01 == 6)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I exited my vehicle with my hands up. The guardsman patted me down.";
            }

            if (buttonCounter01 == 7)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Guard: “Let me scan your Unity Band.”";
            }

            if (buttonCounter01 == 8)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Here you go.”";
            }

            if (buttonCounter01 == 9)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Guard: “You have insufficient Creds. You may not pass.”";
            }

            if (buttonCounter01 == 10)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “There’s a civil war out here. I need to get in.”";
            }

            if (buttonCounter01 == 11)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Guard: “Enlist with the barrack officer over there in that building. " +
                    "You can gain credits for securing the border.”";
            }

            if (buttonCounter01 == 12)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’ll see to it, sir.”";
                buttonCounter01++;
            }

            if (buttonCounter01 == 14)
            {
                counter++;
                buttonCounter01 = 0;
                buttonCounter02 = 0;
            }
        }
    }

    private void Section07()
    {
        if (counter == 6)
        {
            if (buttonCounter01 == 0)
            {
                title.GetComponent<TextMeshProUGUI>().text = "VII: Credibility";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "As I left the guardsman, fear emerged deeply in my thoughts. Never have I thought to join the " +
                    "military or be in a civil war. I’m fucked.";
            }

            if (buttonCounter01 == 1)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Barrack Officer: “You come to join the efforts in securing our borders?”";
            }

            if (buttonCounter01 == 2)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Yes sir!”";
            }

            if (buttonCounter01 == 3)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Barrack Officer: “Let me scan your Unity Band. Then you may go put on a uniform and assist the guards outside.”";
            }

            if (buttonCounter01 == 4)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Yes sir.”";
            }

            if (buttonCounter01 == 5)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I left the barracks and helped the guards secure the gate. We checked the credentials of " +
                    "people seeking entry into Citadel.";
            }

            if (buttonCounter01 == 6)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Stop! Please get out of the vehicle with your hands up.”";
            }

            if (buttonCounter01 == 7)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Stranger: “Yes, sir.”";
            }

            if (buttonCounter01 == 8)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’m going to pat you down and then scan your Unity Band.”";
            }

            if (buttonCounter01 == 9)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Stranger: “Okay.”";
            }

            if (buttonCounter01 == 10)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Nick: “Not enough Creds to pass the gate, James. Please enlist with the barrack officer in the " +
                    "building over there to help with the efforts or go back to where you came from.”";
                Credit(2);
                buttonCounter01++;
            }

            if (buttonCounter01 == 12)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Stop! Please get out of the vehicle with your hands up.”";
            }

            if (buttonCounter01 == 13)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Stranger: “O... ok.”";
            }

            if (buttonCounter01 == 14)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’m going to pat you down and then scan your Unity Band.”";
            }

            if (buttonCounter01 == 15)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Stranger: “...”";
            }

            if (buttonCounter01 == 16)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Nick: “You've been black listed, Kaycee. Please, go back to where you came from.”";
                Credit(4);
                buttonCounter01++;
            }

            if (buttonCounter01 == 18)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Stop! Please get out of the vehicle with your hands up.”";
            }

            if (buttonCounter01 == 19)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Stranger: “Yes.”";
            }

            if (buttonCounter01 == 20)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’m going to pat you down and then scan your Unity Band.”";
            }

            if (buttonCounter01 == 21)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Stranger: “Please- let me in!”";
            }

            if (buttonCounter01 == 22)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Nick: “You may enter the gates, Ryan.”";
                Credit(2);
                buttonCounter01++;
            }

            if (buttonCounter01 == 24)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Night had fallen. I was exhausted of saying the same commands to people seeking sanctuary at Citadel. " +
                    "Most people didn’t pass. It was sad seeing their disappointed faces. Especially knowing I was " +
                    "gaining Creds for securing the border.";
                Credit(32);
                buttonCounter01++;
            }

            if (buttonCounter01 == 26)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Guard: “Nick, please report back to the Barrack Officer.”";
            }

            if (buttonCounter01 == 27)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Right away.”";
                buttonCounter01++;
            }

            if (buttonCounter01 == 29)
            {
                counter++;
                buttonCounter01 = 0;
                buttonCounter02 = 0;
            }
        }
    }

    private void Section08()
    {
        if (counter == 7)
        {
            if (buttonCounter01 == 0)
            {
                title.GetComponent<TextMeshProUGUI>().text = "VIII: Rebel Back";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Barrack Officer: “Nick, you’re to be deployed towards the East gate. There you’ll meet up with " +
                    "General James Moore Sr. General Moore needs servicemen to fight back the rebels. " +
                    "Here is a rifle and some cartridges. Make haste while the night is still out.";
            }

            if (buttonCounter01 == 1)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Ye – yess, sir.”";
            }

            if (buttonCounter01 == 2)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I left the barracks with rifle in hand. I could see fire far beyond us. That’s where I was headed. " +
                    "Straight to hell it seemed. No doubt I am scared. I don’t even know how to fire this damn rifle.";
            }

            if (buttonCounter01 == 3)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Maintaining a low profile, clinging to the walls of Citadel, I made my way to the east gate. Hours passed by " +
                    "while on foot. The night stayed with me and the fire in the distance came closer. Suddenly, I heard voices up ahead.";
            }

            if (buttonCounter01 == 4)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "“Plant the charge here,” whispered a man.";
            }

            if (buttonCounter01 == 5)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "“I’m trying. Hard to see what the fuck I am doing here,” whispered another man.";
            }

            if (buttonCounter01 == 6)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "I extended my rifle in hand, towards the voices. I approached slowly and quietly to get a look… A " +
                    "bag enveloped me. I dropped the rifle and struggled to get free.";
            }

            if (buttonCounter01 == 7)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "Man: “I got one!”";
            }

            if (buttonCounter01 == 8)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = "I was hit upon the head. Instantly knocked out.";
                buttonCounter01++;
            }

            if (buttonCounter01 == 10)
            {
                counter++;
                buttonCounter01 = 0;
                buttonCounter02 = 0;
            }
        }
    }

    private void Section09()
    {
        if (counter == 8)
        {
            if (buttonCounter01 == 0)
            {
                title.GetComponent<TextMeshProUGUI>().text = "IX: Hard Choices";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "As I gained conscious, I slowly opened my eyes to a strange room with lights and rebels.";
            }

            if (buttonCounter01 == 1)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Rebel: “Welcome back Nick. Join our efforts against the Creditors or die here. I’ll give a minute to " +
                    "think. I’m going to step outside.”";
                button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Assist the Rebels effort instead";
                button02.SetActive(true);
                button02.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Remain a loyalist and escape";
            }

            if (buttonCounter02 == 0)
            {
                if (buttonCounter01 == 2)
                {
                    jack = true;
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Rebel: “I’m back. So, have you decided Nick?”";
                }

                if (buttonCounter01 == 3)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “I’ll join the Rebels.”";
                }

                if (buttonCounter01 == 4)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "Rebel: “Excellent. I’m Jack Knight, the Rebel Leader. Here’s your rifle. We set for the east " +
                        "gate where General Moore and his troops are. We must eliminate them to get into Citadel.”";
                }

                if (buttonCounter01 == 5)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Nick: “Alright, let’s go.”";
                }

                if (buttonCounter01 == 6)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "Jack: “But first we cut off your Unity Band.”";
                    credits.SetActive(false);
                }

                if (buttonCounter01 == 7)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "We headed towards the east gate of Citadel. 9 months would pass us. Hundreds of lives were lost on " +
                        "both sides of the conflict. Working alongside Jack Knight was intriguing to me.";
                }

                if (buttonCounter01 == 8)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "Jack Knight is a 29-year-old, slim guy well educated in computer technology. Jack knew how to hack " +
                        "into the social credit system, dismantling the Creditors infrastructures of servers and cameras. " +
                        "Together, we kept the Rebels a step ahead of the Creditors. It wasn’t long before, we captured " +
                        "General Moore.";
                    buttonCounter01++;
                }

                if (buttonCounter01 == 10)
                {
                    counter++;
                    buttonCounter01 = 0;
                    buttonCounter02 = 0;
                }
            }
            else
            {
                if (buttonCounter01 == 1)
                {
                    button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                    button02.SetActive(false);
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "I freed myself from the chair that I was bound to. I fled the room. I took out any Rebels in my way " +
                        "with my bare hands until I could retrieve a rifle. Once acquiring a rifle and ammunition, I battled " +
                        "my way out of the building I was captured in.";
                }

                if (buttonCounter01 == 2)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "As I left the Rebel outpost, I made my way towards the east gate of Citadel. I contacted General " +
                        "Moore and his troops. We began to fight back the Rebels. 9 months would pass us. Hundreds of " +
                        "lives were lost on both sides of the conflict. Working alongside General Moore was intriguing to me.";
                }

                if (buttonCounter01 == 3)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "General Moore is a 45-year-old, fat man with bluntness like no other. Moore was one hell of an " +
                        "army general. He knew the ways of combat. Together, we kept the Rebels back. It wasn’t " +
                        "long before, we captured and executed Jack Knight, the Rebel Leader.";
                }

                if (buttonCounter01 == 4)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "As I recall his face, Jack Knight was the one who talked to me when I was bound to that chair, " +
                        "9 months ago. Jack was a 29-year-old, slim guy well educated in computer technology. Jack knew " +
                        "how to hack into the social credit system, disrupting our infrastructures of servers and " +
                        "cameras. It’s too bad his talents we’re ill-used.";
                    buttonCounter01++;
                }

                if (buttonCounter01 == 6)
                {
                    counter++;
                    buttonCounter01 = 0;
                    buttonCounter02 = 0;
                }
            }
        }
    }

    private void Section10()
    {
        if (counter == 9)
        {
            if (jack)
            {
                if (buttonCounter01 == 0) {
                    title.GetComponent<TextMeshProUGUI>().text = "X: Sanctuary";
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "The Rebels gained a foothold within Citadel. After the fall of General Moore, there wasn’t many " +
                        "Creditors willing to give their lives. We dismantled the entire social credit system. Imprisoned " +
                        "Clara Jaine Bells, the old president of Citadel. Jack Knight become the leader of the people. " +
                        "We began the process of rebuilding a new world without social credit again.";
                    buttonCounter01++;
                }
            }
            else
            {
                if (buttonCounter01 == 0) {
                    title.GetComponent<TextMeshProUGUI>().text = "X: Sanctuary";
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "We the Creditors restored Citadel back. I was awarded many Creds for my war efforts. Enough Creds to " +
                        "finally get the house I always wanted.";
                    Credit(250);
                    buttonCounter01++;
                }
            }

            if (alli)
            {
                if (buttonCounter01 == 2)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = 
                        "Perhaps, I can get that second date with Allison.\n\nThe End";
                    buttonCounter01++;
                }
            }
            else
            {
                if (buttonCounter01 == 2)
                {
                    dialogue.GetComponent<TextMeshProUGUI>().text = "The End";
                    buttonCounter01++;
                }
            }

            if (buttonCounter01 == 4)
            {
                counter++;
                buttonCounter01 = 0;
                buttonCounter02 = 0;
            }
        }
    }

    private void Section11()
    {
        if (counter == 10)
        {
            if (buttonCounter01 == 0)
            {
                button01.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Continue";
                button02.SetActive(true);
                button02.transform.Find("Label").GetComponent<TextMeshProUGUI>().text = "Exit";
                title.GetComponent<TextMeshProUGUI>().text = "Research";
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "“A Look Inside China’s Social Credit System | NBC News Now.” YouTube, YouTube, 4 June 2019, " +
                    "https://www.youtube.com/watch?v=0cGB8dCDf3c." +
                    "\n\nThis documentary shows how the Sesame Credit system works. People are profiled and judged " +
                    "accordingly by their actions of good and bad. Gain points for responsible purchasing of brands. " +
                    "Lose points for jaywalking, littering, speeding, or any minor crimes.";
            }

            if (buttonCounter01 == 1)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Campbell, Charlie. “How China Is Using Big Data to Create a Social Credit Score.” Time, Time, " +
                    "14 Aug. 2019, https://time.com/collection/davos-2019/5502592/china-social-credit-score/." +
                    "\n\nThis article explains the Sesame Social Credit System in China, where scores range from 350 to " +
                    "950 and are monitored by technology companies, Alibaba, Ant Financial, and others.";
            }

            if (buttonCounter01 == 2)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Ma, Alexandra. “China Has Started Ranking Citizens with a Creepy 'Social Credit' System - Here's " +
                    "What You Can Do Wrong, and the Embarrassing, Demeaning Ways They Can Punish You.” Business Insider, " +
                    "Business Insider, 29 Oct. 2018, https://www.businessinsider.com/china-social-credit-system-punishments-and-rewards-explained-2018-4." +
                    "\n\nThis article illustrates the various punishment the Chinese Social Credit has in play (for this story).";
            }

            if (buttonCounter01 == 3)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "“Social Credit: China's Digital Dystopia In The Making.” YouTube, YouTube, 5 Oct. 2018, " +
                    "https://www.youtube.com/watch?v=evBzPwCdeHI." +
                    "\n\nThis documentary shows how the Sesame Credit system works. Here it’s mentioned that social " +
                    "circles affect credit. Credit will limit a citizen’s freedom in terms of traveling. Credit will " +
                    "also affect purchasing power regardless of wealth.";
            }

            if (buttonCounter01 == 4)
            {
                dialogue.GetComponent<TextMeshProUGUI>().text = 
                    "Zhang, Phoebe. “China's Social Credit System Expands to Target Benefits Fraud.” Scmp, South China " +
                    "Morning Post, 27 Nov. 2019, https://www.scmp.com/news/china/society/article/3039625/chinas-social-credit-system-expands-target-social-security-fraud." +
                    "\n\nThis article mentions that Chinese citizen receive social credit for blood donation. I imagine this " +
                    "could apply to those who serve their country.";
            }

            if (buttonCounter01 == 5)
            {
                button01.SetActive(false);
            }
        }
    }
}
