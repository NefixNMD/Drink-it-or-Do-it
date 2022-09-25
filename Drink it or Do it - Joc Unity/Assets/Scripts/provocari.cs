using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class provocari : MonoBehaviour
{
    public int randomizare;

    public string alegeProvocarea(){
        string prov;
        randomizare = Random.Range(1,122);
        switch(randomizare)
        {
            case 1:
                prov = "Feed a food item to your partner using just your mouth OR Drink";               
                break;
            case 2:
                prov = "Do 35 squats OR Drink";               
                break;
            case 3:
                prov = "Send a dirty message to your ex OR Drink";               
                break;
            case 4:
                prov = "Pose like a supermodel for 10 seconds OR Drink";               
                break;
            case 5:
                prov = "Post an unflattering picture on instagram story OR Drink";               
                break;
            case 6:
                prov = "Eat chocolate with mayonnaise OR Drink";               
                break;
            case 7:
                prov = "Ask your crush about his/her virginity OR Drink";               
                break;
            case 8:
                prov = "Moan loudly and passionately OR Drink";               
                break;
            case 9:
                prov = "Dance on the table OR Drink";               
                break;
            case 10:
                prov = "Twerk for 30 seconds OR Drink";               
                break;
            case 11:
                prov = "Try to put your feet behind your head OR Drink";               
                break;
            case 12:
                prov = "Spank a guy’s butt OR Drink";               
                break;
            case 13:
                prov = "Give someone a lap dance OR Drink";               
                break;
            case 14:
                prov = "Keep an ice cube in your pants or socks till it melts OR Drink";               
                break;
            case 15:
                prov = "Let the group post anything they want on your social media OR Drink";               
                break;
            case 16:
                prov = "Kiss the person next to you wherever she/he wants OR Drink";               
                break;
            case 17:
                prov = "Stuff one of your fingers in your nose then in your mouth OR Drink";               
                break;
            case 18:
                prov = "Stuff one of your fingers in your nose then in your partner’s mouth OR Drink";               
                break;
            case 19:
                prov = "Show the group your dms on instagram OR Drink";               
                break;
            case 20:
                prov = "Send a topless snap to someone ( bra can stay on ) OR Drink";               
                break;
            case 21:
                prov = "Lick someone’s cheek OR Drink";               
                break;
            case 22:
                prov = "Call your mother and tell her: „ I’m at the police station” with a serious voice OR Drink";               
                break;
            case 23:
                prov = "Exchange a clothing item with the person on your right OR Drink";               
                break;
            case 24:
                prov = "Dance with no music OR Drink";               
                break;
            case 25:
                prov = "Stand on your arms as long as you can OR Drink";               
                break;
            case 26:
                prov = "Peel a banana with your feet OR Drink";               
                break;
            case 27:
                prov = "Have the person to the left put lipstick on you....while blindfolded OR Drink";               
                break;
            case 28:
                prov = "Do a model runway walk OR Drink";               
                break;
            case 29:
                prov = "Sit on the lap of the person on your right for 3 minutes OR Drink";               
                break;
            case 30:
                prov = "Sit there in nothing but your underwear OR Drink";               
                break; 
            case 31:
                prov = "Go around the room and smell everyone’s armpits OR Drink";               
                break;
            case 32:
                prov = "Show the most embarrasing photo on your phone OR Drink";               
                break;
            case 33:
                prov = "Eat a raw piece of garlic OR Drink";               
                break;
            case 34:
                prov = "Give a foot massage to the person on your right OR Drink";               
                break;
            case 35:
                prov = "Remove 3 items of clothing OR Drink";               
                break;
            case 36:
                prov = "Seductively eat a banana OR Drink";               
                break;
            case 37:
                prov = "Try to lick your elbow OR Drink";               
                break;
            case 38:
                prov = "Give a kiss to each player in the room OR Drink";               
                break;
            case 39:
                prov = "Text a stranger guy: „ How is your sister ?” OR Drink";               
                break;
            case 40:
                prov = "Seranade the person to your left for 20 seconds OR Drink";               
                break; 
            case 41:
                prov = "Let the person on your right draw on your face OR Drink";               
                break;
            case 42:
                prov = "Crack an egg with your head OR Drink";               
                break;
            case 43:
                prov = "Perform ballet for 1 minute OR Drink";               
                break;
            case 44:
                prov = "Do a belly dance for 1 minute OR Drink";               
                break;
            case 45:
                prov = "Eat a raw egg OR Drink";               
                break;
            case 46:
                prov = "Howl like a wolf for 10 seconds OR Drink";               
                break;
            case 47:
                prov = "Let each person in the room paint one of your nails OR Drink";               
                break;
            case 48:
                prov = "Tell the group 2 truths and a lie. They have to guess which one is the lie OR Drink";               
                break;
            case 49:
                prov = "Reply to the first five instagram stories on your timeline OR Drink";               
                break;
            case 50:
                prov = "Slow dance with the person on your left for one song OR Drink";               
                break; 
            case 51:
                prov = "Write a message only using your toes OR Drink";               
                break;
            case 52:
                prov = "Kiss a member of the same gender OR Drink";               
                break;
            case 53:
                prov = "Lick the floor OR Drink";               
                break;
            case 54:
                prov = "Lick the door OR Drink";               
                break;
            case 55:
                prov = "Get slapped on the face by the person you choose OR Drink";               
                break;
            case 56:
                prov = "Eat a spoon full of mustard OR Drink";               
                break;
            case 57:
                prov = "Empty your wallet/purse and show everyone what is inside OR Drink";               
                break;
            case 58:
                prov = "Send a sext to the last person in your phonebook OR Drink";               
                break;
            case 59:
                prov = "Ask a friend if he/she is interested in being „friends with benefits” OR Drink";               
                break;
            case 60:
                prov = "Become the slave of another player of your choosing for 5 minutes OR Drink";               
                break; 
            case 61:
                prov = "Tell something very intimate OR Drink";               
                break;
            case 62:
                prov = "Call a pizza place and order sardines OR Drink";               
                break;
            case 63:
                prov = "Eat a peeled banana without using your hands OR Drink";               
                break;
            case 64:
                prov = "Draw a face around your belly button OR Drink";               
                break;
            case 65:
                prov = "Eat cream/ketchup/mustard/syrup from anyone’s belly button OR Drink";               
                break;
            case 66:
                prov = "Kiss the feet of the person on your front OR Drink";               
                break;
            case 67:
                prov = "Run around the room imitating a monkey OR Drink";               
                break;
            case 68:
                prov = "Hold hands with the person to your right for 60 seconds OR Drink";               
                break;
            case 69:
                prov = "Chew a napkin for 10 seconds OR Drink";               
                break;
            case 70:
                prov = "Remove your sock with your teeth OR Drink";               
                break; 
            case 71:
                prov = "Massage your nipples for 10 seconds OR Drink";               
                break;
            case 72:
                prov = "Rub your armpits and then smell your fingers OR Drink";               
                break;
            case 73:
                prov = "Massage the person next to you nipples for 10 seconds OR Drink";               
                break;
            case 74:
                prov = "Keep your hand between someone’s thighs for 1 minute OR Drink";               
                break;
            case 75:
                prov = "Give someone a massage anywhere he/she wants for 5 minutes OR Drink";               
                break;
            case 76:
                prov = "Let someone in the group text your crush OR Drink";               
                break;
            case 77:
                prov = "Put your bra and underwear on over top of your clothes OR Drink";               
                break;
            case 78:
                prov = "Take off your bra and put it on one of the boys in the group OR Drink";               
                break;
            case 79:
                prov = "Eat a spoon of flour OR Drink";               
                break;
            case 80:
                prov = "Keep a spoon of oil in your mouth for 1 minute without swallow it OR Drink";               
                break; 
            case 81:
                prov = "Have your partner lay their head in your lap and give them a sensual head massage OR Drink";               
                break;
            case 82:
                prov = "Take off someone’s shirt without using your hands OR Drink";               
                break;
            case 83:
                prov = "Let someone draw with lipstick on your back OR Drink";               
                break;
            case 84:
                prov = "Striptease for 1 minute OR Drink";               
                break;
            case 85:
                prov = "Put lipstick on and give the person next to you 5 neck marks OR Drink";               
                break;
            case 86:
                prov = "Undress your partner with one hand OR Drink";               
                break;
            case 87:
                prov = "Kiss someone in the room that you’re attracted to OR Drink";               
                break;
            case 88:
                prov = "Leave a sexy voicemail to your ex to listen to OR Drink";               
                break;
            case 89:
                prov = "Pick a sexy position and imitate it with the person to your left OR Drink";               
                break;
            case 90:
                prov = "Eat a leaf OR Drink";               
                break; 
            case 91:
                prov = "Let someone draw a mono eyebrow to you OR Drink";               
                break;
            case 92:
                prov = "Put a trap song and dance like the guys in the video OR Drink";               
                break;
            case 93:
                prov = "Recreate a famous photo/scene OR Drink";               
                break;
            case 94:
                prov = "Make out with a stuffed animal for 30 seconds OR Drink";               
                break;
            case 95:
                prov = "Touch your nose with another person nose for 5 seconds OR Drink";               
                break;
            case 96:
                prov = "Eat raw meat OR Drink";               
                break;
            case 97:
                prov = "Mix a spoon of sugar and beer in your mouth OR Drink";               
                break;
            case 98:
                prov = "Take a shot of vinegar OR Drink";               
                break;
            case 99:
                prov = "Show the colour of your panties to the whole group OR Drink";               
                break;
            case 100:
                prov = "Let someone put mascara on OR Drink";               
                break; 
            case 101:
                prov = "Stick your cheek with the person next to you for 1 minute OR Drink";               
                break;
            case 102:
                prov = "Carry the person in front of you for 10 seconds OR Drink";               
                break;
            case 103:
                prov = "Do the penguin dance on your own OR Drink";               
                break;
            case 104:
                prov = "Do the macarena dance OR Drink";               
                break;
            case 105:
                prov = "Post a picture of your feet on instagram story : Anyone into foot fetish or is just me ? OR Drink";               
                break;
            case 106:
                prov = "Go live on social media for 20 seconds OR Drink";               
                break;
            case 107:
                prov = "Do 10 pushups OR Drink";               
                break;
            case 108:
                prov = "Jump for 13 seconds OR Drink";               
                break;
            case 109:
                prov = "Play next round on doggy style OR Drink";               
                break;
            case 110:
                prov = "Karaoke „I will always love you” by Whitney Houston OR Drink";               
                break; 
            case 111:
                prov = "Spin around for 30 seconds OR Drink";               
                break;
            case 112:
                prov = "Write a word with your mouth OR Drink";               
                break;
            case 113:
                prov = "Let the person next to you put their finger in your mouth OR Drink";               
                break;
            case 114:
                prov = "Let everyone in the group touch your ass OR Drink";               
                break;
            case 115:
                prov = "Send a dick pic OR Drink";               
                break;
            case 116:
                prov = "Drink a glass of milk and juice mixed OR Drink";               
                break;
            case 117:
                prov = "Eat a bowl of warm water with the spoon OR Drink";               
                break;
            case 118:
                prov = "Kiss everyone hands OR Drink";               
                break;
            case 119:
                prov = "Wear a drawn moustache for the rest of the game OR Drink";               
                break;
            case 120:
                prov = "Play next round on your knees OR Drink";               
                break; 
            case 121:
                prov = "Just drink :)";               
                break;
            case 122:
                prov = "";               
                break;
            case 123:
                prov = "";               
                break;
            case 124:
                prov = "";               
                break;
            case 125:
                prov = "";               
                break;
            case 126:
                prov = "";               
                break;
            case 127:
                prov = "";               
                break;
            case 128:
                prov = "";               
                break;
            case 129:
                prov = "";               
                break;
            case 130:
                prov = "";               
                break; 
            case 131:
                prov = "";               
                break;
            case 132:
                prov = "";               
                break;
            case 133:
                prov = "";               
                break;
            case 134:
                prov = "";               
                break;
            case 135:
                prov = "";               
                break;
            case 136:
                prov = "";               
                break;
            case 137:
                prov = "";               
                break;
            case 138:
                prov = "";               
                break;
            case 139:
                prov = "";               
                break;
            case 140:
                prov = "";               
                break; 
            case 141:
                prov = "";               
                break;
            case 142:
                prov = "";               
                break;
            case 143:
                prov = "";               
                break;
            case 144:
                prov = "";               
                break;
            case 145:
                prov = "";               
                break;
            case 146:
                prov = "";               
                break;
            case 147:
                prov = "";               
                break;
            case 148:
                prov = "";               
                break;
            case 149:
                prov = "";               
                break;
            case 150:
                prov = "";               
                break;              
            default:
                prov = "Just drink :)"; 
                break;
        }
        return prov;
    }
}
