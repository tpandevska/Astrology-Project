using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astrology_Project
{
    public class DailyHoroscope
    {
        public static readonly List<String> ariesText = new List<String>
        {
            "It’s easy to get swept up off into a world of fantasy today, Aries. The sun locks into a square with dizzying Neptune today, creating a foggy atmosphere mentally. Be especially mindful of the messages you’re sending out and receiving, as it's easy to misread someone's tone and potentially form an inaccurate judgment. It’s an ideal day to get lost in a movie or creative project, as you’re looking to shine on a stage of your own.",
            "As an Aries, you tend not to devote excessive time to home and family matters. Let yourself reconnect with these realms today, as the homebody Cancer moon summons you back toward your roots. Luna spends the day without making any contacts, seeing it as a perfectly care-free, low-action day. Aim to keep things low-key and to spruce up your living space. This is so your foundations can support you.",
            "Your life is beginning to switch gears, Aries. Stoic Saturn locks into a tight square with change-bringer Uranus today—bringing little earthquakes to your career path and community connections. Lean into the shift and embrace what's asking to be let go of or altered. Elsewhere, the playful Leo moon encourages you to side-step any stress by engaging in your favorite creative outlets.",
            "Devote time to the close relationships in your world today, Aries. The moon floats through other-oriented Libra, directing your focus towards your current partnership story. Luna’s harmonious link with expressive Mercury makes it an ideal day for important conversations that need to run smoothly. Later on, family bonds can pose some tensions, as the moon squares off with Venus.",
            "As an Aries, you’re here to focus on developing your own individuality. Yet, you don’t always have to go at it alone. Friday’s skies work to remind you of that, as the moon floats through graceful Libra and links up with your ruling planet, self-motivated Mars. This connection fuels your interest in romantic relationships today and makes it an ideal day to send some TLC towards the partnerships in your life.",
            "You’ve been on-the-go non-stop lately, Aries. It’s been important for you to stay engaged and explore new opportunities in all of your running around. Yet, today’s skies work to help you course-correct and narrow in on a clearer path forward. The first quarter moon in diligent Virgo arrives today, helping you hone your craft and become more organized and efficient with your workflow.",
            "Life has been stretching you beyond your comfort zone, Aries. Let yourself recuperate from those exhausting demands and embrace a much-needed break today. The moon glides through good-time craving Leo today, pushing you to immerse yourself into any pleasurable activities you cherish. Tuesday’s low-key skies help return a state of balance, as Luna and the sun harmoniously align.",
        };

        public static readonly List<String> taurusText = new List<String>
        {
            "Be cautious with your purchases today, Taurus. All that glitters isn’t gold, and you may be apt to overextend with your spending on something that you may later come to regret. The sun’s square with reality-bending Neptune is to blame for the haze. On the upside, this aspect does add a romantic haze to the day that's worth digging into your inspiration for. Let yourself get creative instead of needing to fill the void with material things.",
            "Your whole world has been under reconstruction, Taurus. Monday’s skies only continue to hone in on that story and push you toward finding a breakthrough. Structure-seeking Saturn butts up against rebellious Uranus under Monday’s skies. This supercharged aspect pushes you to welcomingly renew outgrown parts of your career and belief system. Elsewhere, the lazy Leo moon encourages quiet, restful time spent on the home front.",
            "As a Taurus, you crave peace of mind above all else. Let yourself carve out a restful space to unwind in today, as the moon floats through relaxed Leo. Luna’s smooth connection with the sun allows for a sense of equilibrium to return—especially between your finances and home life. Take a beat to sit with yesterday’s revelations and peacefully reconnect with family members.",
            "You’re in desperate need of a good time, Taurus. What makes you happy? Find that activity and reconnect with it unabashedly today, as the moon glides into down-to-earth Virgo. The moon’s minimal contacts make for a slow-paced day—so, who cares if you slack off and prioritize pleasure over work? Later on, the moon links up with electric Uranus, bringing an invigorated energy to your self-expression.",
            "This time of year is all about getting in touch with your skills, Taurus. What are you not using and which skills are you looking to better hone? Today’s first quarter moon in decisive Virgo helps you narrow in on this story, as it highlights changes needing to be around your self-confidence. Don’t be afraid to find yourself a stage and share from the heart.",
            "Taurus people have an enviable work ethic. Don’t be afraid to put it to good use today, as you’re likely to be in the mood for productive action. The moon floats into balance-seeking Libra, helping you even yourself back out after a couple of indulgent days. Use this time to hone in on exercise, mindful meals, and taking forward strides work-wise. Luna’s link with hyperactive Mars gives you fuel to deal with home projects too. ",
            "Let yourself ride out the productive wave you’re on, Taurus. The moon coasts through logic-first Libra all day, pointing your focus towards the unfinished tasks on your to-do list. Luna’s smooth connection with quick-thinking Mercury makes it easy for you to keep your mind sharp and stay on track with anything you apply yourself towards. Later, the moon’s square to your ruler, Venus, may prompt unexpected, emotional conversations. "
        };

        public static readonly List<String> geminiText = new List<String>
        {
            "It’s easy to fall sway to illusions about your potential today, Gemini. The sun locks into a square with reality-melting Neptune. Rather than believe any deceptive mirages about your goals, allow yourself to get swept up in the ripe inspiration that this aspect permeates the day with. Be especially mindful of your boundaries, and don’t be afraid to draw the line between your career’s demands and your personal needs.",
            "Let the old misconceptions you’ve held onto about life fall away today, Gemini. The universe is clearing a new path forward, but you have to be willing to let go of the old ways of being. Tradition-focused Saturn locks into a tense square with change-bringer Uranus today, prompting you to renew outgrown relationship approaches and to release self-sabotaging mental patterns.",
            "You’ve got a story to tell today, Gemini. Don’t keep your thoughts all to yourself, as the Leo moon encourages you to find your own personal stage and vulnerably share. It’s an ideal day to work on a writing project, have an important conversation, or get lost in a journaling session. Luna’s harmonious connection with the sun allows for a smooth running, emotionally balanced day all around.",
            "Your quiet twin needs some airtime today, Gemini. Pull away from the noise and let yourself recuperate in the quiet comforts of your home. The moon wanders through reflective Virgo, sending you on a nostalgic inward journey. It’s an ideal day to catch up with friends of yesteryear and family members. The moon’s late-night link with Uranus can bring surprises out into the open.",
            "You are your own top priority right now, Gemini. It’s critical for you to invest energy into building a new sense of identity and independence during your birthday season. Today’s first quarter moon in decisive Virgo highlights important changes needing to be embraced around your home environment and family connections. Which familial bonds nurture you and which ones bind you to the past?",
            "Let yourself shake off the heavy feelings that have been clinging to your back, Gemini. Friday’s skies work to help you prioritize fun and pleasure over all else, as the moon meanders into beauty-seeking Libra. Luna spends the day in a supportive connection with energized Mars, making it an especially ideal time to devote time to passion projects—as you have the stamina and creative power to make them sparkle.",
            "You’re likely to be feeling fired up on the creative front today, Gemini. The moon meanders through beauty-seeking Libra and harmoniously aligns with your ruling planet, messenger Mercury. This aspect does wonders for your charisma and draws attention to your identity, so don’t be shy about woo-ing a special someone. Later, Luna’s square to Venus can stir up financial worries."
        };

        public static readonly List<String> cancerText = new List<String>
        {
            "Be careful of what you choose to act on today, Cancer. You’re likely to be lost in a world greener pastures, as the sun squares off with truth-bending Neptune. While this aspect is disorienting, it also creates a gentle dreaminess that is worth steeping in. Luna’s departure from your sign into enthusiastic Leo can make you feel like you need to make moves, but double-check the idyllic spin you might be putting on things.",
            "It’s no surprise that your relationships have been in a state of transformation, Cancer. Let yourself embrace some change in that arena today, as stagnant Saturn locks into a square with shake-it-up Uranus. This highly-charged aspect pushes you to examine any outgrown relationship patterns and acknowledge what needs a hard refresh. Elsewhere, the excitable Leo moon encourages productivity over passivity.",
            "It’s easy to feel in sync with yourself today, Cancer. The moon roams through colorful Leo, lifting spirits and reconnecting you with your untapped talents. The cosmic landscape is light and low-key, which makes it easy for you to find your footing and stay productive on any of your current projects. Luna’s sweet connection with the sun boosts confidence and evens out any imbalances.",
            "As a Cancer, you tend to hold your tongue at times when you should actually be speaking up. Remind yourself of this tendency today, as the moon glides through poignant Virgo and urges you to engage with your voice. It’s an ideal day to return missed texts and emails, get absorbed in an honest heart-to-heart, or immerse yourself in an activity that relaxes you.",
            "Spring tends to be a strange time of year for you, Cancer. Don’t sweat it if you don’t feel like yourself—as you’ve been actively trying to release outgrown, inhibiting patterns. Today’s first quarter moon in Virgo highlights the current state of your mental health and your ability to express yourself. It’s an ideal day for journaling and active releasing.",
            "Cancerians regularly need to withdraw into their cozy shell and recharge themselves. You’re in need of some time at home to recuperate today, as the moon wanders into peace-seeking Libra. It’s an ideal day to send energy towards beautifying your home and letting go of old junk. Luna’s energizing link with motivated Mars may have you making impulse purchases, so be mindful of your desire to eagerly spend.",
            "You need to feel a part of something today, Cancer. Reach out to your family, as you’re longing to make close contact and be your sentimental self. Luna’s presence in peaceable Libra helps maintain levity and her smooth link with messenger Mercury helps you feast on insights that bubble up from deep within. Later, the moon’s square to Venus can prompt feelings around unmet relationship needs. "
        };

        public static readonly List<String> leoText = new List<String>
        {
            "Everything is not what it seems under Friday’s mystifying skies, Leo. Your ruling planet, the life-giving sun, floats out to sea with dream-maker Neptune today. This pairing is likely to lower your energy levels and increase your need for escapism. Let yourself drift today without needing to make any decisive, serious choices. The moon’s entrance into your sign helps you listen to your body and independent needs.",
            "Relationships have been an ongoing point of tension for you this year, Leo. Keep leaning into the changes being encouraged today, as stuck Saturn squares off with electric Uranus. This energizing aspect can jolt you awake, as it pinpoints any old and outgrown circumstances around your current partnership story. The moon’s presence in your sign reminds you to stay grounded and tuned into your body. ",
            "Be selfish today, Leo. You have every right to assert your needs. Things may have become a bit unbalanced in your relationship in recent days—so, don’t be afraid to share your side of the story. The moon’s presence in your sign encourages you to reconnect in a meaningful way with your body, health, and appearance. Luna’s link with your ruler, the sun, lends a sense of capability and confidence.",
            "You need structure to feel your best today, Leo. Let yourself get lost in productive action today, as the clarity-seeking Virgo moon pushes you to focus on activating your skills. It’s an ideal day for anything involving a realistic mindset, as you’re able to think practically and make financially-sound choices. Luna’s evening link with Uranus can bring a fresh wave of inspiration to career matters.",
            "The universe is pushing you to build upon your personal goals today, Leo. The first quarter moon arrives in capable Virgo, prompting you to embrace changes in attitude and approach towards your aspirations. This lunation may highlight snags in your financial situation and illuminate self-confidence issues that need healing. Which goals are worth pursuing and which are no longer worthwhile?",
            "Don’t expect yourself to sit still under Friday’s skies, Leo. There are things to do and places to see! The moon floats into logical Libra, helping you tap into your mental health and assess your needs. Luna’s link with Mars makes it an ideal day for any opportunities that feature your charisma. It’s also an ideal day to journal, read, sing—anything that helps you get your story out in the open.",
            "Don’t hold your tongue today, Leo. There are things you long to speak up on, and you have all the resources you need to do it. The gentle Libra moon aligns with communicator Mercury today, making it an ideal one for important conversations concerning your goals. Look to your friends, as they hold the insight to your forward movement. Later, Luna’s square with Venus can stir up mixed feelings around old relationship wounds."
        };

        public static readonly List<String> vigroText = new List<String>
        {
            "As a Virgo, you rarely like to lose control over your reality. Sunday’s skies encourage you to surrender to your senses in a dreamworld, as the sun squares off with reality-bending Neptune. This aspect is a dizzying one that can lend to confusion around your career path and partnership involvements. It’s an ideal day to spend some time alone in quiet reflection in your favorite nature spot.",
            "You need an extended weekend, Virgo. Don’t expect yourself to pleasantly leap into action today, as the heart-centered Leo moon encourages rest, solitude, and retreat. Elsewhere, stagnant Saturn and change-bringer Uranus clash. This highly charged aspect brings a wake-up call to any outgrown circumstances around your work life. Lean into the changes being summoned and the old stories will fall away.",
            "Another day out of the spotlight will do you good, Virgo. Let yourself withdraw into a healing world of your own creation, as the self-focused Leo moon calls for peace and self-preservation. Tuesday’s skies are welcomingly soothing and low-key, so don’t stress things by going against the flow. Luna’s sweet link with the sun provides a sense of equilibrium—especially around career matters.",
            "It’s easy for you to get lost in your head, Virgo. Today’s skies remind you to reconnect with your body and come back down to earth, as the moon glides forward into your sign. Luna’s presence here makes it an ideal day to devote yourself to some TLC, as her lack of contacts creates a low-activity day. Embrace the opportunity to sync back up with your own needs for once!",
            "Your career is of utmost importance to you this time of year, Virgo. Are you setting clear and realistic goals for yourself? The universe is urging you to go after what you want wholeheartedly. Today’s first quarter moon in your sign encourages you to make changes around your sense of independence and identity. How are you hindering your own forward movement?",
            "You’ve got a wealth of talents that are just waiting to be tapped into, Virgo. Friday’s skies push you to take a look at your abilities and bring them to life, as the moon floats into beauty-seeking Libra. It’s also a good time to check in on your saving and spending habits. Luna’s formidable connection with go-getter Mars makes it easy to push ahead with personal projects and to stay productive. ",
            "You’ve got everything you need to get ahead today, Virgo. Rather than rest on your laurels, aim to push ahead with your personal projects. The rational Libra moon sweetly aligns with your ruling planet, messenger Mercury. This contact makes it easy to stay on task with career goals and deal with the logical, laborious side of things. Later, Luna’s square to Venus can prompt mixed feelings around a situation concerning your friends."
        };

        public static readonly List<String> libraText = new List<String>
        {
            "Today’s cosmic landscape is something of a dreamscape, Libra. Don’t believe everything that you see or feel, as the sun locks into a dizzying square with reality-melting Neptune. This aspect is likely to bring confused feelings between the reality of your current job landscape and the big picture vision you’re building for yourself. That aside, this pairing creates a romantic, dreaminess that’s hard not to enjoy.",
            "Surrender to the changes being demanded of your relationships today, Libra. Tradition-maintaining Saturn butts heads with change-bringer Uranus, bringing little earthquakes to the partnership and intimacy arena. Let yourself lean into the shifts, as this aspect points to what needs releasing and renewal around your approach to romance. The moon’s presence in playful Leo suggests that you turn to your friend groups for support.",
            "You’ve been working so hard on getting ahead, Libra. Let yourself pull back from that mission briefly today, if only to reconnect with your sense of community and friends. The playful Leo moon spends the day harmoniously aligned with the sun, bringing a sense of balance to your vision and long-term goals. It’s an ideal day to slip away with or sync back up with your pals and let the good times roll.",
            "Let yourself retire from the world today, Libra. You’re likely to be in the mood to hole up and hide away, as the moon glides into reflective Virgo. This transition encourages you to seek out solitude and peace. It’s an ideal day to cleanse your space and minimize any junk you’ve collected. Luna’s little cosmic action renders the day low-key, so don’t feel the need to be a productive member of society.",
            "Now’s the time to get out of your comfort zone, Libra. You’ve been exploring new avenues for education and self-expansion, perhaps in a way that makes you nervous. Keep bravely pursuing this new frontier as you inch closer to clarity. Today’s first quarter moon in diligent Virgo brings important changes to light in terms of self-sabotaging behavior patterns that need to be better managed.",
            "As a Libra, you tend to give your energy away to others without thinking of yourself first. Friday’s skies encourage you to abandon that mode of action and send attention inwards toward yourself. The moon floats into your sign this morning, signaling a strong need to come back to your body and individual needs. Spend the day putting yourself first and load up on the TLC that you need!",
            "You’re hard to miss today, Libra. Put yourself out there and embrace your shine, as the moon’s presence in your sign centers people's focus on you. The moon spends the day in a supportive alignment with expressive Mercury, making it easy for you to speak with charisma. It’s an ideal day to put yourself on a stage of your choosing. Later on, the moon’s square to your ruler, Venus, can unleash unexpressed emotions concerning your career path."

        };

        public static readonly List<String> scorpioText = new List<String>
        {
            "Things might begin to get confusing in the romance department today, Scorpio. The sun floats out to sea with disorienting Neptune today, potentially making you see your current relationship stories all that clearly. Refrain from making any major decisions regarding partners, as you’re likely to be looking at things with rose colored glasses. If things are mostly settled, you can enjoy the soft, escapist fog this pairing creates with someone special.",
            "The ground is shifting beneath your feet today, Scorpio. Rather than grasping for stability, allow yourself to freely float. Structure-building Saturn locks into a tense square with change-bringer Uranus—highlighting any old, worn-out stories brewing around your home and family environment. Embrace any opportunity to refresh and renew these lifelong connections. Elsewhere, the show-stopping Leo moon calls attention to your current career trajectory.",
            "Career matters seem to reign supreme under Tuesday’s skies, Scorpio. The dazzling Leo moon calls your attention to your reputation and mission in society and asks you to examine what you can do to get closer to achieving your goals. Luna’s sweet connection with the sun provides a welcome sense of stability to relationship matters. Devote your energy to a personal project and endeavor to feel your best.",
            "Reconnect with your people today, Scorpio. The moon slides into practical Virgo this morning, prompting you to feel like a part of something bigger. It’s an ideal day to plan something with friends or reach out to those special people in your life who you’ve fallen out of touch with. Your community and social network hold the key to your good mood today, so don’t make yourself an island.",
            "You’ve been trekking through the darkness of your own heart, Scorpio. The universe is working to help you heal and release yourself from the ancient relationship baggage that you’ve been lugging around. Today’s first quarter moon in precision-seeking Virgo highlights changes needing to be made around your sense of community and social connection. What friends have your back? Which are no longer making the cut?",
            "Pull away from the world today, Scorpio. You’re probably in the mood to move away to an isolated island without human contact. Rather than be so drastic, just let yourself recharge. The moons presence in balance-seeking Libra urges you to focus on restorative activities, nature, and solitude. Luna’s link to your ruler, go-getter Mars, gives you energy to plod away at passion projects too.",
            "Let yourself prioritize your own peace today, Scorpio. The moon’s presence in calm-seeking Libra focuses your efforts on slowing down and reconnecting to your own needs. It’s an ideal day to seek out your favorite nature spot, ignore your phone, and unplug from reality. The moon’s harmonious link with messenger Mercury helps you embrace important, emotionally revealing conversations in partnerships."
        };

        public static readonly List<String> sagittariuesText = new List<String>
        {
            "You’re not likely to be seeing things all that clearly today, Sagittarius. The sun gets lost in a dreamy bind with reality-bending Neptune today, creating fertile grounds for confusion and illusion around your close relationships. Aim to wait on making any major decisions around partnerships with this mystifying energy present. That aside, if your partnership is stable, you can embrace the romantic, hazy feel this pairing presents.",
            "Lean into the changes being asked of you beneath Monday’s skies, Sagittarius. Stagnant Saturn locks into an earth-shaking square with invigorating Uranus, highlighting the changes needing to be made around your mental health and communication style in connection to your work/life balance. This aspect spotlights some of the key stories of your year, so pay close attention to today’s happenings.",
            "Let yourself get out of your normal routine today, Sagittarius. Part of what’s been bogging you down is your inability to find a fresh perspective and engage in some adventure. Tuesday’s skies allow you to find some space and regain your footing, as the playful Leo moon harmoniously aligns with the sun. This aspect allows for a stabilizing sense of balance to return to your relationships as well.",
            "Dial into the needs of your career today, Sagittarius. The moon’s presence in capable Virgo offers you the chance to sink your teeth into something and stay focused. Devote some energy into making your workflow operate more efficiently, or simply spend some time figuring out what the next step is in your current plan. Luna’s late-night meet-up with Uranus can bring a fresh wave of inspiration to the work front.",
            "What’s happening in the world of your reputation, Sagittarius? Some changes are needing to be made to get closer to where you want to be ambition-wise. Today’s first quarter moon in diligent Virgo highlights the changes needed in order to move forward. Look to anyone you’re in close collaboration with to get to the heart of this story. What compromises are worthwhile and which are holding you back?",
            "Reconnect with your people today, Sagittarius. You’ve been so enmeshed in relationship dramas, both romantic and family, that you’re likely in need of some levity. Luna’s presence in peace-seeking Libra urges you to reconnect with friends and find your social network today. Luna’s supportive link with self-motivated Mars provides you with the energy to find adventure and shake things up.",
            "Go after your goals today, Sagittarius. They needn’t be gigantic to be meaningful, and you can accomplish a lot if you let yourself get started. The logical Libra moon aligns with expressive Mercury today, allowing you to make headway in any collaborative efforts that benefit your aspirations. Later, Luna’s square with lover Venus can stir up unfinished business to be explored in the romance arena."
        };

        public static readonly List<String> capicornText = new List<String>
        {
            "As a Capricorn, you have a close relationship with control. Let yourself ease up on the reins to have it all figured out today. Your ruling planet, stoic Saturn, locks into a square with change-bringer Uranus. This highly charged aspect highlights any old and outworn feelings around your self-confidence that need a refresh. Lean into your intense need for change and space without burning bridges. ",
            "As a Capricorn, you rarely let your messier feelings swim up to the surface for air. Tuesday’s skies encourage you to prioritize healing today, as you sift through yesterday’s unsettling material. The heartfelt Leo moon encourages you to dive deep within yourself, free up stuck feelings, and confide in intimate contacts. Luna’s sweet link with the sun allows for clarity and stability on the work front",
            "Another day of the same ol’, same ol’ is bound to make you nuts, Capricorn. Find a way to reinvigorate your routine today, as the moon slides into capable Virgo. Luna’s presence here directs your attention to your current travel plans, educational ventures, and big picture vision of life. Get out of the norm to enliven your perspective and watch the rest fall into place.",
            "This time of year is all about putting your nose to the grindstone, Capricorn. Thursday’s skies encourage you to look closer at what you’re working toward, as the first quarter moon arrives in diligent Virgo. What changes need to be embraced mentally for you to get closer to your newly developing vision? How can you manifest what you want when you continue to doubt your abilities? ",
            "You’re ready to put the work in, Capricorn. Even if it’s the weekend, you’re feeling inspired to make things happen on the career front. What’s your mission? Spend some time delving into your ambitions today, as the balance-seeking Libra moon pushes you to explore a different perspective around your trajectory. Luna’s energizing link with go-getter Mars helps you put the work in and stay on track.",
            "You’ve got everything you need to make strides on the ambition front today, Capricorn. Rather than think of your day job, focus your attention on what you want to meaningfully contribute to society. The rational Libra moon aligns with mentally-sharp Mercury, making it easy to focus on honing your craft and pushing ahead. Later, the moon’s square to Venus can spark disagreements on the partnership front.",
            "Today’s cosmic landscape encourages a departure from reality, Capricorn. You’re likely to be hungry for an escape from the norm and you may find yourself dreaming up greener pastures on the job front. The dizzying square between the sun and elusive Neptune today is to blame. Lean into your need to drift off into the deep recesses of your mind and see what feelings are looking for acknowledgement."
        };

        public static readonly List<String> aquariusText = new List<String>
        {
            "You need a fresh dose of change, Aquarius. Lean into the cosmic shifts emerging today, as your ruling planet, Saturn, butts heads with invigorating Uranus. This highly potent aspect highlights important change needing to be embraced around your identity and home life. Where can you free yourself up from ancient binds? This contact also increases your need for freedom and space, which lead you to act a bit erratically.",
            "What’s going with your relationships, Aquarius? Send your focus to the intimate one-on-ones in your life that may need some extra TLC. The moon prowls through your opposite sign of Leo, directing your attention toward your current partnership story. Luna harmoniously aligns with the sun too, bringing a sense of stability to creative projects and equilibrium to recent romantic revelations.",
            "As an Aquarius, you’re not often one for big, messy, emotional displays. This is especially true when those displays might be your own! Today’s skies encourage you to actually sit with and acknowledge any unsettled feelings, in hopes of avoiding the aforementioned scenario. It’s an ideal day to commit yourself to a therapeutic practice or confide in a lover. Later, the moon’s link with Uranus brings surprising developments to the home front.",
            "You’ve been busy devoting yourself to the pleasures of life, Aquarius. That’s exactly where you should be, as you reconnect with your creative drive and romantic life in a refreshed and meaningful way. Today’s first quarter moon in reflective Virgo brings you into a different headspace, one where you’re asked to examine some of your long-held relationship hang-ups in an honest light. Can you let another in without having to totally disregard your boundaries?",
            "Get out of your comfort zone today, Aquarius. You’re craving a fresh landscape—one that will re-enliven your inspiration and help you find a fresh perspective. The moon moves forward into beauty-seeking Libra today, making it an ideal day for a road trip or to find some local adventure. Luna’s smooth connection with Mars makes it an energizing date day, so do something active together!",
            "Your mind is hungry for new information today, Aquarius. Let yourself get lost in a good book, a cool museum, or a trip out of town to help you reset yourself. Luna’s sweet connection with expressive Mercury makes it an ideal date day, as you’re likely to be overflowing with witty banter and have light, but meaningful conversations. Later, the moon’s square to Venus can prompt mixed feelings on the work front.",
            "Let yourself sink your teeth into the imaginative atmosphere offered up by Today’s skies, Aquarius. The sun locks into a dizzying square with reality-bending Neptune today, which can create questionable feelings around the potential of your raw talent. Rather than get lost in deceptive feelings, let yourself activate your creative side and drift into an inspiring headspace. This energy also can simply encourage rest and dreaminess, if you’re not up for activity!"
        };

        public static readonly List<String> piscesText = new List<String>
        {
            "The week kicks off with a bang today, Pisces. Stagnant Saturn locks into a tense square with change-bringer Uranus, an aspect that activates the most important, ongoing stories of your year. This highly charged contact highlights the changes needing to be made around your own self-sabotaging behavior and its effects on your mental health. The fiery Leo moon reminds you to get into your body if things get too riled up.",
            "Sink your teeth into your workload today, Pisces. The moon roams through energized Leo, sending your focus toward unfinished business. Luna’s supportive connection with the sun brings a sense of balance around home and family matters that allows you to put the blinders on and get things done. Turn your focus towards your diet, health, and exercise regimen if your mood needs to be uplifted.",
            "Take a good look at your partnerships today, Pisces. The moon glides into your opposite sign of sharply realistic Virgo, helping you tune into your current relationship story. Are you speaking up about your needs or are you side-stepping them? It’s an ideal day to touch base with yourself, or a partner, on what you can do to help love flourish.",
            "This is one of the trickiest times of year, Pisces. You’re navigating ancient material around your family life and trying to build a solid foundation for yourself—emotionally and domestically. Thursday’s skies illuminate this story even further, as the first quarter moon arrives in practical Virgo. This lunation highlights changes needing to be made around your closest relationships. What elements of your past are you projecting onto your present?",
            "This weekend’s focus is around healing and intimate contact, Pisces. The moon slides into other-oriented Libra today, tilting your attention towards unexpressed emotions around your relationship story. Refrain from excessive socialization, as you’re more in the mood to be an introvert and do some psychological digging within. Luna’s energizing link with Mars offers stamina on any work projects.",
            "As a Pisces, you crave intimate soul contact with a select few other people. Let yourself inhabit that natural longing today, as the big-hearted Libra moon propels you into deeply exploring your current relationship story. The moon’s smooth link with talkative Mercury makes it easy to have healing conversations—especially with family members. Later, the moon’s argument with Venus can stir up mixed feelings around romantic relations.",
            "It’s easy to get swept out to sea today, Pisces. The sun locks into a disorienting square with reality-melting Neptune today, creating either overly idyllic or deceptive feelings around family members and your involvement with them as an individual. Don’t lose your boundaries to people who wind up being energy-drainers, even if they are family. That aside, this aspect makes an ideal day for drifting and embracing rest."
        };

        public string getTodayHoroscope(int day, string sign)
        {
            if (sign.Equals("Aries"))
            {
                return ariesText[day % 7];
            }
            else if (sign.Equals("Taurus"))
            {
                return taurusText[day % 7];
            }
            else if (sign.Equals("Gemini"))
            {
                return geminiText[day % 7];
            }
            else if (sign.Equals("Cancer"))
            {
                return cancerText[day % 7];
            }
            else if (sign.Equals("Leo"))
            {
                return leoText[day % 7];
            }
            else if (sign.Equals("Virgo"))
            {
                return vigroText[day % 7]; 
            }
            else if (sign.Equals("Libra"))
            {
                return libraText[day % 7];
            }
            else if (sign.Equals("Scorpio"))
            {
                return scorpioText[day % 7];
            }
            else if (sign.Equals("Sagittarius"))
            {
                return sagittariuesText[day % 7];
            }
            else if (sign.Equals("Capricorn"))
            {
                return capicornText[day % 7];
            }
            else if (sign.Equals("Aquarius"))
            {
                return aquariusText[day % 7];
            }
            else if (sign.Equals("Pisces"))
            {
                return piscesText[day % 7];
            }
            else
            {
                return "Invalid date!";
            }
        }
    }
}
