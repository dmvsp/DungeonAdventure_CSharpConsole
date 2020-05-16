using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonAdventure_CSharpConsole
{
    static class Localization
    {
        static String[] englishLocalText = {   "Skeleton",
                                        "Zombie",
                                        "Warrior",
                                        "Assasin",
                                        "Welcome to the Dungeon Adventure !",
                                        "appeared",
                                        "Your HP",
                                        "HP",
                                        "What you like to do ?",
                                        "1. Attack",
                                        "2. Drink health potion",
                                        "3. Run !",
                                        "You strike the",
                                        "for",
                                        "damage.",
                                        "You receive",
                                        "in retaliation.",
                                        "You have taken too much damage, you are too weak to go on !",
                                        "You drink a health potion, healing youself for",
                                        "You now have",
                                        " HP.",
                                        "You have",
                                        " potions left.",
                                        "You have no health potions left! Defeat enemies for a chance to get one !",
                                        "You run away from the",
                                        "Bad input ! (Press 1,2 or 3 to continue)",
                                        " was defeated!",
                                        "You have",
                                        "HP left",
                                        "The",
                                        "dropped a health potion !",
                                         "Now you have",
                                         "health potion(s)",
                                        "You limp out of the dungeon, weak from battle. Thank for playing !",
                                        "What you like to do now ?",
                                        "1. Continue fighting",
                                        "2. Exit dungeon",
                                        "You continue on your adventure !",
                                        "You exit the dungeon, successful from your adventures ! Thank you for playing !"
                                     };
        static String[] russianLocalText = {
                                        "Скелет",
                                        "Зомби",
                                        "Воин",
                                        "Убийца",
                                        "Добро пожаловать в Подземелье !",
};
        public enum LocalLang { RU, ENG };
        public enum LocalItem : int { 
                                        Skeleton,
                                        Zombie,
                                        Warrior,
                                        Assasin,
                                        Welcome 
                                    };
        static public string GetLocalText(LocalLang lang, LocalItem item )
        {
            return lang == LocalLang.RU ? russianLocalText[(int)item] : englishLocalText[(int)item];
        }
    }
}
