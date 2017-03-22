Module Module1

    Private Property Answer As String
    Private Property Scissors As String
    Private Property Scissors2 As String
    Private Property Morning As String
    Private Property Continue2 As String
    Private Property Tonight As String
    Private Property Dress As String
    Private Property Dress1 As String
    Private Property Change As String
    Private Property Boy1 As String
    Private Property Boy1Continued As String
    Private Property Boy1Continued2 As String
    Private Property Change1 As String
    Private Property Boy2 As String
    Private Property Boy2Continued As String
    Private Property Boy2Continued2 As String
    Private Property Bad1 As String
    Private Property Bad1Continued As String
    Private Property Bad2 As String
    Private Property Bad2Continued As String

    'Added select Loop for the ability to do try, catch.
    Private Property selectLoop = True


    Sub Main()
        Console.WriteLine("")
        Console.WriteLine("Your name is Sebastian.")
        Console.WriteLine("")
        Console.WriteLine("You are seventeen years old.")
        Console.WriteLine("")

        'Put Question in loop so that it will be re-asked if user chooses an invalid option.
        While selectLoop = True
            Console.WriteLine("You look In the mirror what Do you see?")
            Console.WriteLine("")
            Console.WriteLine("1. Long straight brown hair")
            Console.WriteLine("")
            Console.WriteLine("2. Short choppy brown hair")
            Answer = Console.ReadLine() 'This line stores what the user types as a string in the "Answer" varible.

            If Answer = "1" Then

                'Jump into the Story Ark 1 Sub Module this way your code will be eaiser to keep track of
                'and your game won't be one giant If-Else Statement.
                StoryArc1()

                'Set selectLoop to False to exit loop at exit of StoryArc1() Sub Module.
                selectLoop = False

            ElseIf Answer = "2" Then

                'Jump into the Story Ark 2 Sub Module
                StoryArc2()

                'Set selectLoop to False to exit loop at exit of StoryArc2() Sub Module.
                selectLoop = False

            Else

                'You don't have to do this but I moved the "Not a choice bruh" to it's own Sub so you can just call it
                'With NotAChoice() anywhere you want in your program.
                NotAChoice()

            End If
        End While

    End Sub

    Sub StoryArc1()
        Console.WriteLine("")
        Console.WriteLine("You take a deep breath As you stare at your reflection In the mirror.")
        Console.WriteLine("")
        Console.WriteLine("Your Long brown hair Is up In a bun To Try To make it more manageable And your eyes scan over")
        Console.WriteLine("the makeup around your eyes And On your lips.")
        Console.WriteLine("")
        Console.WriteLine("You hate it all. Your hair. The makeup.")
        Console.WriteLine("")
        Console.WriteLine("Everything.")
        Console.WriteLine("")
        Console.WriteLine("You wanted To Like what you saw In the mirror but you didn't. You couldn't like who you saw in your reflection.")
        Console.WriteLine("")
        Console.WriteLine("You open up the medicine cabinet to grab the makeup remover but stop when you see a pair of scissors.")
        Console.WriteLine("")
        Console.WriteLine("You always asked them if you could cut your hair but they always said 'no'.")
        Console.WriteLine("")
        Console.WriteLine("'Why would you want to cut your hair, Lacey? It's so pretty long.' They would say.")
        Console.WriteLine("")
        Console.WriteLine("You think that your parents won't be home for awhile.")
        Console.WriteLine("")
        Console.WriteLine("You could do it.")
        Console.WriteLine("")
        Console.WriteLine("Do you take the scissors?")
        Console.WriteLine("")
        Console.WriteLine("1. Take the scissors")
        Console.WriteLine("")
        Console.WriteLine("2. Hesitation")
        Console.ReadLine()

        Scissors = Console.ReadLine()

        If Scissors = "1" Then

            Console.WriteLine("")
            Console.WriteLine("You You feel your heart start to beat faster in your chest as the idea sticks in your head, and before you really")
            Console.WriteLine("know it you had the pair of scissors in your hand. You take a few deep breaths, closing your eyes for a few seconds,")
            Console.WriteLine("")
            Console.WriteLine("'Don't think about it. Just do it.' You say to yourself, opening your eyes again.")
            Console.WriteLine("")
            Console.WriteLine("With a shaky hand, you cut the first few strands of hair, watching as they floated down into the sink in front of you")
            Console.WriteLine("You let out a laugh, although you're not totally sure why. A new found courage takes over you as you hold the scissors")
            Console.WriteLine("firmly in your hand and you started to cut away at your hair.")
            Console.WriteLine("To continue press 1")
            Console.ReadLine()

            Scissors2 = Console.ReadLine()

        ElseIf Scissors = "2" Then

            Console.WriteLine("")
            Console.WriteLine("Your hand stops halfway to the scissors as you feel fear settle into your chest.")
            Console.WriteLine("")
            Console.WriteLine("What will happen if you cut your hair? Mom and Dad won't be happy about it.")
            Console.WriteLine("")
            Console.WriteLine("The thought of how your parents would react makes your confidence falter.")
            Console.WriteLine("")
            Console.WriteLine("'It's now or never' You think to yourself with the last remains of your confidence.")
            Console.WriteLine("")
            Console.WriteLine("Do you take the scissors or do you grab the makeup remover?")
            Console.WriteLine("")
            Console.WriteLine("1. Take the scissors")
            Console.WriteLine("")
            Console.WriteLine("2. Grab the makeup remover")
            Console.ReadLine()

            Scissors2 = Console.ReadLine()

            If Scissors2 = "1" Then

                Console.WriteLine("")
                Console.WriteLine("You feel your heart start to beat faster in your chest as the idea sticks in your head, and before you really")
                Console.WriteLine("know it you had the pair of scissors in your hand. You take a few deep breaths, closing your eyes for a few seconds,")
                Console.WriteLine("")
                Console.WriteLine("'Don't think about it. Just do it.' You say to yourself, opening your eyes again.")
                Console.WriteLine("")
                Console.WriteLine("With a shaky hand, you cut the first few strands of hair, watching as they floated down into the sink in front of you")
                Console.WriteLine("You let out a laugh, although you're not totally sure why. A new found courage takes over you as you hold the scissors")
                Console.WriteLine("firmly in your hand and you started to cut away at your hair.")
                Console.WriteLine("")
                Console.WriteLine("To continue press 1")
                Console.ReadLine()

                Continue2 = Console.ReadLine()

                If Continue2 = "1" Then
                    Console.WriteLine("")
                    Console.WriteLine("For the first time in a long time you find yourself grinning at your reflection in the mirror. There are")
                    Console.WriteLine("clumps of your once long hair around your feet and you set the scissors down on the bathroom sink.")
                    Console.WriteLine("")
                    Console.WriteLine("The choppy hairstyle that you've given yourself is nothing to brag about but it's finally short. ")
                    Console.WriteLine("")
                    Console.WriteLine("You put the scissors down and run your fingers through your hair, laughing to yourself when you feel some")
                    Console.WriteLine("ares where it's cut way too short or not enough.")
                    Console.WriteLine("")
                    Console.WriteLine("You almost forgot about how your parents would react but the sound of the front door opening shocks")
                    Console.WriteLine("you back into reality.")
                    Console.WriteLine("")
                    Console.WriteLine("You look at the hair around the bathroom floor and on your hoodie as you hear your mom call your name.")
                    Console.WriteLine("")
                    Console.WriteLine("She's clearly drunk again.")
                    Console.WriteLine("")
                    Console.WriteLine("You hear your dad's voice booming from the downstairs and your heart hammers in your chest as you look")
                    Console.WriteLine("at your reflection in the mirror.")
                    Console.WriteLine("")
                    Console.WriteLine("Look what you've done.")
                    Console.WriteLine("")
                    Console.WriteLine("You grip the edges of the sink until your knuckles turn white and take a deep breath.")
                    Console.WriteLine("")
                    Console.WriteLine("Everything will be okay in the morning.")
                    Console.WriteLine("")
                    Console.WriteLine("Press 1 to continue")
                    Console.ReadLine()

                Else

                    Console.WriteLine("")
                    Console.WriteLine("Not an option bruh")
                    Console.ReadLine()

                End If

            ElseIf Scissors2 = "2" Then
                Console.WriteLine("")
                Console.WriteLine("You spend a long moment staring at the scissors. Your fear of your parents get the best of")
                Console.WriteLine("you and you reach for the makeup remover instead and close the medicine cabinet.")
                Console.WriteLine("")
                Console.WriteLine("You carefully remove the makeup staining your face, ignoring the weight on your")
                Console.WriteLine("chest as you look at your reflection in the mirror.")
                Console.WriteLine("")
                Console.WriteLine("This isn't right.")
                Console.WriteLine("")
                Console.WriteLine("This isn't right.")
                Console.WriteLine("")
                Console.WriteLine("You hear the front door open and close and your mom calls your name.")
                Console.WriteLine("")
                Console.WriteLine("She's clearly drunk again.")
                Console.WriteLine("You hear you dad's voice booming from the downstairs and your heart hammers in your chest as")
                Console.WriteLine("you look at your reflection in the mirror.")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("Tonight is not a good night.")
                Console.WriteLine("")
                Console.WriteLine("Enter 1 twice to continue")
                Console.ReadLine()

                Tonight = Console.ReadLine()

                If Tonight = "1" Then

                    Console.WriteLine("")
                    Console.WriteLine("Your name is Sebastian and you know that you're supposed to stay in this dress but it doesn't")
                    Console.WriteLine(" feel right. ")
                    Console.WriteLine("")
                    Console.WriteLine("It's been a month since the ' incident' and most of the bruises have healed. At least they ")
                    Console.WriteLine(" would've if your mom didn't get drunk every other day and your dad didn't have that temper.")
                    Console.WriteLine("")
                    Console.WriteLine("At least none of the bruises were visible. They were good at hitting where your long sleeves")
                    Console.WriteLine("and other clothes would hide them.")
                    Console.WriteLine("")
                    Console.WriteLine("You grimace at the dress.")
                    Console.WriteLine("")
                    Console.WriteLine("You go to your closet and kneel down, moving a few things around until you find the bag that  ")
                    Console.WriteLine("you're looking for")
                    Console.WriteLine("")
                    Console.WriteLine("You smile to yourself as you open the bag to find the white button up shirt and black slacks.")
                    Console.WriteLine("")
                    Console.WriteLine("You don't really remember why you had bought these, but at least they were coming in handy now.")
                    Console.WriteLine("")
                    Console.WriteLine("You can hear people still talking downstairs and a spike of anxiety runs down your spine.")
                    Console.WriteLine("")
                    Console.WriteLine("Your mom might actually kill you if you go downstairs in a button up and slacks.")
                    Console.WriteLine("")
                    Console.WriteLine("Which do you put on?")
                    Console.WriteLine("")
                    Console.WriteLine("1. Keep on the dress")
                    Console.WriteLine("")
                    Console.WriteLine("2. Put on the button up")
                    Console.ReadLine()

                    Dress1 = Console.ReadLine()

                    If Dress1 = "1" Then

                        Console.WriteLine("")
                        Console.WriteLine("Your fear of what would happen makes you take a long look at the bag before you shove it back in the closet.")
                        Console.WriteLine("")
                        Console.WriteLine("You try not to think about how wrong it feels as you put on the dress.")
                        Console.WriteLine("")
                        Console.WriteLine("You find yourself staring at your reflection in the full length mirror. You feel like something heavy")
                        Console.WriteLine(" is sitting on your chest.")
                        Console.WriteLine("")
                        Console.WriteLine("Dread.")
                        Console.WriteLine("")
                        Console.WriteLine("You look at yourself in the mirror and that feeling isn't going away")
                        Console.WriteLine("")
                        Console.WriteLine("You try to tell yourself 'My name is Sebastian. My name is Sebastian.'")
                        Console.WriteLine("over and over again. It's not making you feel better like it usually does.")
                        Console.WriteLine("")
                        Console.WriteLine("You feel helpless.")
                        Console.WriteLine("")
                        Console.WriteLine("You look at the button up and slacks and the brief moment of happiness is gone.")
                        Console.WriteLine("")
                        Console.WriteLine("You'll never be able to wear that.")
                        Console.WriteLine("")
                        Console.WriteLine("You'll never be able to come out as Sebastian.")
                        Console.WriteLine("")
                        Console.WriteLine("Your parents will never accept you coming out as transgender.")
                        Console.WriteLine("")
                        Console.WriteLine("Press 1 to continue")
                        Console.ReadLine()

                        Bad1 = Console.ReadLine()

                        If Bad1 = "1" Then

                            Console.WriteLine("")
                            Console.WriteLine("You lock yourself in the bathroom. That dread isn't going away.")
                            Console.WriteLine("")
                            Console.WriteLine("You reach into the medicine cabinet and you find your mom's antidepressants.")
                            Console.WriteLine("")
                            Console.WriteLine("Perfect.")
                            Console.WriteLine("")
                            Console.WriteLine("You hesitate for a few seconds, staring down at the bottle but as soon as you")
                            Console.WriteLine("look as your reflection in the mirror and see who's staring back at you..")
                            Console.WriteLine("")
                            Console.WriteLine("The party will be over soon and your window of opportunity is closing.")
                            Console.WriteLine("")
                            Console.WriteLine("It'll all be over soon.")
                            Console.WriteLine("")
                            Console.WriteLine("Press 1 to continue")
                            Console.ReadLine()

                            Bad1Continued = Console.ReadLine()

                            If Bad1Continued = "1" Then

                                Console.WriteLine("")
                                Console.WriteLine("Your name was Sebastian.")
                                Console.WriteLine("")
                                Console.WriteLine("You were seventeen.")
                                Console.WriteLine("")
                                Console.WriteLine("You go to the grave as Lacey.")
                                Console.ReadLine()

                            End If


                        End If

                    ElseIf Dress1 = "2" Then

                        Console.WriteLine("")
                        Console.WriteLine("Screw it.")
                        Console.WriteLine("")
                        Console.WriteLine("You can't help but give yourself the finger guns in the full length mirror after ")
                        Console.WriteLine(" you put on the button up and slacks.")
                        Console.WriteLine("")
                        Console.WriteLine("See? Why couldn't you wear stuff like this more often? ")
                        Console.WriteLine("")
                        Console.WriteLine("You take a deep breath before you make your way downstairs.  ")
                        Console.WriteLine("")
                        Console.WriteLine("You try to keep that small bit of confidence as you notice the remaining party ")
                        Console.WriteLine(" guests starting to notice you.")
                        Console.WriteLine("")
                        Console.WriteLine("You straighten out your shirt out of nerves as you try to act like there was")
                        Console.WriteLine(" nothing out of the norm.  ")
                        Console.WriteLine("")
                        Console.WriteLine("At least you were trying to until you spot your mom from across the room.  ")
                        Console.WriteLine("")
                        Console.WriteLine("For lack of better words.. She looked pissed.  ")
                        Console.WriteLine("")
                        Console.WriteLine("You briefly wonder if you can hide in a nearby closet or under the dining room")
                        Console.WriteLine("table but she's already grabbing your arm.  ")
                        Console.WriteLine("")
                        Console.WriteLine("You wince as you feel her fingers dig into the bruises that were already there.")
                        Console.WriteLine(" People were side eyeing the two of you, as your mother smiled that sickly sweet")
                        Console.WriteLine("smile that has that familiar feeling of dread settling in your stomach.  ")
                        Console.WriteLine("")
                        Console.WriteLine("'Lacey, honey.' Your mom starts, 'We still have guests. Why don't you go upstairs")
                        Console.WriteLine(" and change back into the dress until they leave, then we can discuss this?' She")
                        Console.WriteLine(" says it like a suggestion but you can hear the underlining tone of 'If you don't")
                        Console.WriteLine(" go upstairs right now you're going to face hell later'.")
                        Console.WriteLine("Press 1 to continue")
                        Console.ReadLine()

                        Change1 = Console.ReadLine()

                        If Change1 = "1" Then

                            Console.WriteLine("")
                            Console.WriteLine("'I don't want to change. I like these clothes better,' You say, surprised by")
                            Console.WriteLine(" the fact that your voice didn't waver despite how your nerves were all over")
                            Console.WriteLine(" the place.")
                            Console.WriteLine("")
                            Console.WriteLine("It seemed to surprise your mother as well as she glances at the remaining guests")
                            Console.WriteLine(" who were making it no secret that they were listening in on your conversation.")
                            Console.WriteLine("")
                            Console.WriteLine("She lets out a sad attempt of a laugh as her fingers dig into your arm harsher")
                            Console.WriteLine(" making you wince. 'These clothes aren't suited for a young lady.'")
                            Console.WriteLine("")
                            Console.WriteLine("You cringe at the words ' young lady ', 'Mom I like these clothes better. You can")
                            Console.WriteLine(" see as her slight patience starts to run out.")
                            Console.WriteLine("")
                            Console.WriteLine("I won't tell you again, Lacey. Go upstairs and put on the dress. You look like a boy.")
                            Console.WriteLine("")
                            Console.WriteLine("Press 1 to continue.")
                            Console.ReadLine()

                            Boy2 = Console.ReadLine()

                            If Boy2 = "1" Then

                                Console.WriteLine("'Maybe that's because I /am/ a boy.' As soon as the words leave your mouth you wished")
                                Console.WriteLine(" that you could take them back.")
                                Console.WriteLine("")
                                Console.WriteLine("Your mother looks at you, confusion taking the place of the anger, 'What does that mean")
                                Console.WriteLine(" 'You're a boy'?")
                                Console.WriteLine("")
                                Console.WriteLine(" You sort of feel like throwing up, and you had to be as pale as a ghost by now, 'Uh' It")
                                Console.WriteLine(" drags out into a groan, and you look around as if you could somehow get yourself out this")
                                Console.WriteLine(" by not making eye contact with your mom.")
                                Console.WriteLine("")
                                Console.WriteLine("'You understand that you're not a boy, right Lacey?' She has a hint of concern in her voice")
                                Console.WriteLine(" and you have another moment of ' screw it ' in your head.")
                                Console.WriteLine("")
                                Console.WriteLine("'I am a boy.' You repeat.")
                                Console.WriteLine("")
                                Console.WriteLine("Your mother's concern goes back to frustration, 'Don't be dramatic, Lacey. If this is your")
                                Console.WriteLine(" getting out of wearing that dress then it won't work. Now go upstairs and change.'")
                                Console.WriteLine("")
                                Console.WriteLine("You yank your arm out of your mom's hold, 'I'm not being dramatic. I'm a boy.'")
                                Console.WriteLine("")
                                Console.WriteLine("This was definitely not how you had planned to come out but you're here now.")
                                Console.WriteLine("")
                                Console.WriteLine("'I'm transgender, mom.' You should've felt relieved to finally have that out in")
                                Console.WriteLine(" open but all you feel is dread.")
                                Console.WriteLine("")
                                Console.WriteLine("'Stop being dramatic Lacey. You're not a transgender.' She says, and you can hear that tone")
                                Console.WriteLine(" of disgust that you feared she would have.")
                                Console.WriteLine("")
                                Console.WriteLine("You have to stay calm, getting angry won't do anything for you, 'I'm transgender. Not /a/")
                                Console.WriteLine(" transgender, and I would appreciate it if you called me Sebastian.' Your heart is hammering")
                                Console.WriteLine(" and your words finally waver.")
                                Console.WriteLine("")
                                Console.WriteLine("You've had this speech queued up for a while but to actually say it to your mom and not to a")
                                Console.WriteLine(" mirror is completely different.")
                                Console.WriteLine("")
                                Console.WriteLine("'You really expect us to call you something else after we've spent your entire life calling you")
                                Console.WriteLine("Lacey?' That voice makes whatever shread of confidence fade away, and you turn around to see your")
                                Console.WriteLine(" looking down at you.")
                                Console.WriteLine("")
                                Console.WriteLine("Press 1 to continue")
                                Console.ReadLine()

                                Boy2Continued = Console.ReadLine()

                                If Boy2Continued = "1" Then

                                    Console.WriteLine("")
                                    Console.WriteLine("'Party's over.' Your dad says, and if you weren't close to having an anxiety attack you would've")
                                    Console.WriteLine(" laughed at the way the few remaining guests scurried to grab their things before heading out the")
                                    Console.WriteLine("front door.")
                                    Console.WriteLine("")
                                    Console.WriteLine("As soon as the front door shuts you feel like time is moving in slow motion.")
                                    Console.WriteLine("")
                                    Console.WriteLine("They scream at you calling you an 'embarrassment'.")
                                    Console.WriteLine("")
                                    Console.WriteLine("They call you 'tranny'")
                                    Console.WriteLine("")
                                    Console.WriteLine("They tell you 'You're too young to decide something like this'.")
                                    Console.WriteLine("")
                                    Console.WriteLine("You try so hard to tell them they're wrong but whenever you try to they scream over you and hit you.")
                                    Console.WriteLine("")
                                    Console.WriteLine("It felt like hours had passed of their screaming, before they hit you with a final blow")
                                    Console.WriteLine("")
                                    Console.WriteLine("'Get out of this house.'")
                                    Console.WriteLine("")
                                    Console.WriteLine("You're crying now as things start to move too fast.")
                                    Console.WriteLine("")
                                    Console.WriteLine("You have no choice but to watch as your dad marches to your room and starts to throw things into a bag")
                                    Console.WriteLine("for you.")
                                    Console.WriteLine("")
                                    Console.WriteLine("You're sitting on the curb clutching onto the few things that you managed to grab during it all.")
                                    Console.WriteLine("")
                                    Console.WriteLine("Press 1 to continue")
                                    Console.ReadLine()

                                    If Boy2Continued2 = "1" Then

                                        Console.WriteLine("")
                                        Console.WriteLine("Your name is Sebastian.")
                                        Console.WriteLine("")
                                        Console.WriteLine("You're seventeen years old.")
                                        Console.WriteLine("")
                                        Console.WriteLine("You're now homeless.")
                                        Console.WriteLine("")
                                        Console.WriteLine("What do you do now?")
                                        Console.ReadLine()

                                    End If

                                End If

                            End If


                        End If

                    End If
                End If
            End If

        End If

        Console.ReadLine()
    End Sub
    Sub StoryArc2()
        Console.WriteLine("")
        Console.WriteLine("For the first time in a long time you find yourself grinning at your reflection in the mirror. There are")
        Console.WriteLine("clumps of your once long hair around your feet And you set the scissors down on the bathroom sink.")
        Console.WriteLine("")
        Console.WriteLine("The choppy hairstyle that you've given yourself is nothing to brag about but it's finally short. ")
        Console.WriteLine("")
        Console.WriteLine("You put the scissors down and run your fingers through your hair, laughing to yourself when you feel some")
        Console.WriteLine("areas where it's cut way too short or not enough.")
        Console.WriteLine("")
        Console.WriteLine("You almost forgot about how your parents would react but the sound of the front door opening shocks")
        Console.WriteLine("you back into reality.")
        Console.WriteLine("")
        Console.WriteLine("You look at the hair around the bathroom floor and on your hoodie as you hear your mom call your name.")
        Console.WriteLine("")
        Console.WriteLine("She's clearly drunk again.")
        Console.WriteLine("")
        Console.WriteLine("You hear your dad's voice booming from the downstairs and your heart hammers in your chest as you look")
        Console.WriteLine("at your reflection in the mirror.")
        Console.WriteLine("")
        Console.WriteLine("Look what you've done.")
        Console.WriteLine("")
        Console.WriteLine("You grip the edges of the sink until your knuckles turn white and take a deep breath.")
        Console.WriteLine("")
        Console.WriteLine("Everything will be okay in the morning.")
        Console.WriteLine("")
        Console.WriteLine("Enter 1 twice to continue")
        Console.ReadLine()

        Morning = Console.ReadLine()

        If Morning = "1" Then

            Console.WriteLine("")
            Console.WriteLine("Your name is Sebastian and you'd rather put your face on a hot stove than continue to")
            Console.WriteLine(" wear the dress that your mother laid out for you. ")
            Console.WriteLine("")
            Console.WriteLine("It's been a month since what's now known in your mind as the 'hair incident' and most of the")
            Console.WriteLine("bruises have healed. At least they would've if your mom didn't get drunk every other day and")
            Console.WriteLine("your dad didn't have that temper.")
            Console.WriteLine("")
            Console.WriteLine("At least none of the bruises were visible. They were good at hitting where your long sleeves")
            Console.WriteLine("and other clothes would hide them.")
            Console.WriteLine("")
            Console.WriteLine("You grimace at the dress.")
            Console.WriteLine("")
            Console.WriteLine("You go to your closet and kneel down, moving a few things around until you find the bag that  ")
            Console.WriteLine("you're looking for")
            Console.WriteLine("")
            Console.WriteLine("You smile to yourself as you open the bag to find the white button up shirt and black slacks.")
            Console.WriteLine("")
            Console.WriteLine("You don't really remember why you had bought these, but at least they were coming in handy now.")
            Console.WriteLine("")
            Console.WriteLine("You can hear people still talking downstairs and a spike of anxiety runs down your spine.")
            Console.WriteLine("")
            Console.WriteLine("Your mom might actually kill you if you go downstairs in a button up and slacks.")
            Console.WriteLine("")
            Console.WriteLine("Which do you put on?")
            Console.WriteLine("")
            Console.WriteLine("1. Keep on the dress")
            Console.WriteLine("")
            Console.WriteLine("2. Put on the button up")
            Console.ReadLine()

            Dress = Console.ReadLine()

            If Dress = "1" Then

                Console.WriteLine("")
                Console.WriteLine("Your fear of what would happen makes you take a long look at the bag before you shove it back in the closet.")
                Console.WriteLine("")
                Console.WriteLine("You try not to think about how wrong it feels as you put on the dress.")
                Console.WriteLine("")
                Console.WriteLine("You find yourself staring at your reflection in the full length mirror. You feel like something heavy")
                Console.WriteLine(" is sitting on your chest.")
                Console.WriteLine("")
                Console.WriteLine("Dread.")
                Console.WriteLine("")
                Console.WriteLine("You look at yourself in the mirror and that feeling isn't going away")
                Console.WriteLine("")
                Console.WriteLine("You try to tell yourself 'My name is Sebastian. My name is Sebastian.'")
                Console.WriteLine("over and over again. It's not making you feel better like it usually does.")
                Console.WriteLine("")
                Console.WriteLine("You feel helpless.")
                Console.WriteLine("")
                Console.WriteLine("You look at the button up and slacks and the brief moment of happiness is gone.")
                Console.WriteLine("")
                Console.WriteLine("You'll never be able to wear that.")
                Console.WriteLine("")
                Console.WriteLine("You'll never be able to come out as Sebastian.")
                Console.WriteLine("")
                Console.WriteLine("Your parents will never accept you coming out as transgender.")
                Console.WriteLine("")
                Console.WriteLine("Press 1 to continue")
                Console.ReadLine()

                Bad2 = Console.ReadLine()
                If Bad2 = "1" Then

                    Console.WriteLine("")
                    Console.WriteLine("You lock yourself in the bathroom. That dread isn't going away.")
                    Console.WriteLine("")
                    Console.WriteLine("You reach into the medicine cabinet and you find your mom's antidepressants.")
                    Console.WriteLine("")
                    Console.WriteLine("Perfect.")
                    Console.WriteLine("")
                    Console.WriteLine("You hesitate for a few seconds, staring down at the bottle but as soon as you")
                    Console.WriteLine("look as your reflection in the mirror and see who's staring back at you..")
                    Console.WriteLine("")
                    Console.WriteLine("The party will be over soon and your window of opportunity is closing.")
                    Console.WriteLine("")
                    Console.WriteLine("It'll all be over soon.")
                    Console.WriteLine("")
                    Console.WriteLine("Press 1 to continue")
                    Console.ReadLine()

                    Bad2Continued = Console.ReadLine()
                    If Bad2Continued = "1" Then

                        Console.WriteLine("")
                        Console.WriteLine("Your name was Sebastian.")
                        Console.WriteLine("")
                        Console.WriteLine("You were seventeen.")
                        Console.WriteLine("")
                        Console.WriteLine("You go to the grave as Lacey.")
                        Console.ReadLine()

                    End If




                End If

            ElseIf Dress = "2" Then

                Console.WriteLine("")
                Console.WriteLine("Screw it.")
                Console.WriteLine("")
                Console.WriteLine("You can't help but give yourself the finger guns in the full length mirror after ")
                Console.WriteLine(" you put on the button up and slacks.")
                Console.WriteLine("")
                Console.WriteLine("See? Why couldn't you wear stuff like this more often? ")
                Console.WriteLine("")
                Console.WriteLine("You take a deep breath before you make your way downstairs.  ")
                Console.WriteLine("")
                Console.WriteLine("You try to keep that small bit of confidence as you notice the remaining party ")
                Console.WriteLine(" guests starting to notice you.")
                Console.WriteLine("")
                Console.WriteLine("You straighten out your shirt out of nerves as you try to act like there was")
                Console.WriteLine(" nothing out of the norm.  ")
                Console.WriteLine("")
                Console.WriteLine("At least you were trying to until you spot your mom from across the room.  ")
                Console.WriteLine("")
                Console.WriteLine("For lack of better words.. She looked pissed.  ")
                Console.WriteLine("")
                Console.WriteLine("You briefly wonder if you can hide in a nearby closet or under the dining room")
                Console.WriteLine("table but she's already grabbing your arm.  ")
                Console.WriteLine("")
                Console.WriteLine("You wince as you feel her fingers dig into the bruises that were already there.")
                Console.WriteLine(" People were side eyeing the two of you, as your mother smiled that sickly sweet")
                Console.WriteLine("smile that has that familiar feeling of dread settling in your stomach.  ")
                Console.WriteLine("")
                Console.WriteLine("'Lacey, honey.' Your mom starts, 'We still have guests. Why don't you go upstairs")
                Console.WriteLine(" and change back into the dress until they leave, then we can discuss this?' She")
                Console.WriteLine(" says it like a suggestion but you can hear the underlining tone of 'If you don't")
                Console.WriteLine(" go upstairs right now you're going to face hell later'.")
                Console.WriteLine("Press 1 to continue")
                Console.ReadLine()

                Change = Console.ReadLine()

                If Change = "1" Then

                    Console.WriteLine("")
                    Console.WriteLine("'I don't want to change. I like these clothes better,' You say, surprised by")
                    Console.WriteLine(" the fact that your voice didn't waver despite how your nerves were all over")
                    Console.WriteLine(" the place.")
                    Console.WriteLine("")
                    Console.WriteLine("It seemed to surprise your mother as well as she glances at the remaining guests")
                    Console.WriteLine(" who were making it no secret that they were listening in on your conversation.")
                    Console.WriteLine("")
                    Console.WriteLine("She lets out a sad attempt of a laugh as her fingers dig into your arm harsher")
                    Console.WriteLine(" making you wince. 'These clothes aren't suited for a young lady.'")
                    Console.WriteLine("")
                    Console.WriteLine("You cringe at the words ' young lady ', 'Mom I like these clothes better. You can")
                    Console.WriteLine(" see as her slight patience starts to run out.")
                    Console.WriteLine("")
                    Console.WriteLine("I won't tell you again, Lacey. Go upstairs and put on the dress. You look like a boy.")
                    Console.WriteLine("")
                    Console.WriteLine("Press 1 to continue.")
                    Console.ReadLine()

                    Boy1 = Console.ReadLine()

                    If Boy1 = "1" Then

                        Console.WriteLine("")
                        Console.WriteLine("'Maybe that's because I /am/ a boy.' As soon as the words leave your mouth you wished")
                        Console.WriteLine(" that you could take them back.")
                        Console.WriteLine("")
                        Console.WriteLine("Your mother looks at you, confusion taking the place of the anger, 'What does that mean")
                        Console.WriteLine(" 'You're a boy'?")
                        Console.WriteLine("")
                        Console.WriteLine(" You sort of feel like throwing up, and you had to be as pale as a ghost by now, 'Uh' It")
                        Console.WriteLine(" drags out into a groan, and you look around as if you could somehow get yourself out this")
                        Console.WriteLine(" by not making eye contact with your mom.")
                        Console.WriteLine("")
                        Console.WriteLine("'You understand that you're not a boy, right Lacey?' She has a hint of concern in her voice")
                        Console.WriteLine(" and you have another moment of ' screw it ' in your head.")
                        Console.WriteLine("")
                        Console.WriteLine("'I am a boy.' You repeat.")
                        Console.WriteLine("")
                        Console.WriteLine("Your mother's concern goes back to frustration, 'Don't be dramatic, Lacey. If this is your")
                        Console.WriteLine(" getting out of wearing that dress then it won't work. Now go upstairs and change.'")
                        Console.WriteLine("")
                        Console.WriteLine("You yank your arm out of your mom's hold, 'I'm not being dramatic. I'm a boy.'")
                        Console.WriteLine("")
                        Console.WriteLine("This was definitely not how you had planned to come out but you're here now.")
                        Console.WriteLine("")
                        Console.WriteLine("'I'm transgender, mom.' You should've felt relieved to finally have that out in")
                        Console.WriteLine(" open but all you feel is dread.")
                        Console.WriteLine("")
                        Console.WriteLine("'Stop being dramatic Lacey. You're not a transgender.' She says, and you can hear that tone")
                        Console.WriteLine(" of disgust that you feared she would have.")
                        Console.WriteLine("")
                        Console.WriteLine("You have to stay calm, getting angry won't do anything for you, 'I'm transgender. Not /a/")
                        Console.WriteLine(" transgender, and I would appreciate it if you called me Sebastian.' Your heart is hammering")
                        Console.WriteLine(" and your words finally waver.")
                        Console.WriteLine("")
                        Console.WriteLine("You've had this speech queued up for a while but to actually say it to your mom and not to a")
                        Console.WriteLine(" mirror is completely different.")
                        Console.WriteLine("")
                        Console.WriteLine("'You really expect us to call you something else after we've spent your entire life calling you")
                        Console.WriteLine("Lacey?' That voice makes whatever shread of confidence fade away, and you turn around to see your")
                        Console.WriteLine(" looking down at you.")
                        Console.WriteLine("")
                        Console.WriteLine("Press 1 to continue")
                        Console.ReadLine()

                        Boy1Continued = Console.ReadLine()

                        If Boy1Continued = "1" Then

                            Console.WriteLine("")
                            Console.WriteLine("'Party's over.' Your dad says, and if you weren't close to having an anxiety attack you would've")
                            Console.WriteLine(" laughed at the way the few remaining guests scurried to grab their things before heading out the")
                            Console.WriteLine("front door.")
                            Console.WriteLine("")
                            Console.WriteLine("As soon as the front door shuts you feel like time is moving in slow motion.")
                            Console.WriteLine("")
                            Console.WriteLine("They scream at you calling you an 'embarrassment'.")
                            Console.WriteLine("")
                            Console.WriteLine("They call you 'tranny'")
                            Console.WriteLine("")
                            Console.WriteLine("They tell you 'You're too young to decide something like this'.")
                            Console.WriteLine("")
                            Console.WriteLine("You try so hard to tell them they're wrong but whenever you try to they scream over you and hit you.")
                            Console.WriteLine("")
                            Console.WriteLine("It felt like hours had passed of their screaming, before they hit you with a final blow")
                            Console.WriteLine("")
                            Console.WriteLine("'Get out of this house.'")
                            Console.WriteLine("")
                            Console.WriteLine("You're crying now as things start to move too fast.")
                            Console.WriteLine("")
                            Console.WriteLine("You have no choice but to watch as your dad marches to your room and starts to throw things into a bag")
                            Console.WriteLine("for you.")
                            Console.WriteLine("")
                            Console.WriteLine("You're sitting on the curb clutching onto the few things that you managed to grab during it all.")
                            Console.WriteLine("")
                            Console.WriteLine("Press 1 to continue")
                            Console.ReadLine()

                            Boy1Continued2 = Console.ReadLine()


                            If Boy1Continued2 = "1" Then

                                Console.WriteLine("")
                                Console.WriteLine("Your name is Sebastian.")
                                Console.WriteLine("")
                                Console.WriteLine("You're seventeen years old.")
                                Console.WriteLine("")
                                Console.WriteLine("You're now homeless.")
                                Console.WriteLine("")
                                Console.WriteLine("What do you do now?")
                                Console.ReadLine()

                            End If

                        End If


                    End If

                End If

            End If

        Else

            Console.WriteLine("")
            Console.WriteLine("Not a choice bruh")
            Console.ReadLine()

        End If
    End Sub

    'Writes "Not a choice bruh" to the console.
    Sub NotAChoice()
        Console.WriteLine("")
        Console.WriteLine("Not a choice bruh")
        Console.ReadLine()
    End Sub

End Module