using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LogicApp.Helpers
{
    class Data
    {
        public static String[] GroupNames =
        {
            "group1.png", "group2.png", "group3.png", "group4.png", "group5.png", "group6.png", "group7.png", "group8.png"
        };

        public static int[] Letters =
        {
            773,666,321,177,128,205,203,150
        };

        public static String[] GroupDescriptionTitles =
        {
            LogicApp.Resources.AppResources.DescriptionTitleGroup1,
            LogicApp.Resources.AppResources.DescriptionTitleGroup2,
            LogicApp.Resources.AppResources.DescriptionTitleGroup3,
            LogicApp.Resources.AppResources.DescriptionTitleGroup4,
            LogicApp.Resources.AppResources.DescriptionTitleGroup5,
            LogicApp.Resources.AppResources.DescriptionTitleGroup6,
            LogicApp.Resources.AppResources.DescriptionTitleGroup7,
            LogicApp.Resources.AppResources.DescriptionTitleGroup8
        };

        public static String[] GroupDescriptions =
        {
            LogicApp.Resources.AppResources.DescriptionGroup1,
            LogicApp.Resources.AppResources.DescriptionGroup2,
            LogicApp.Resources.AppResources.DescriptionGroup3,
            LogicApp.Resources.AppResources.DescriptionGroup4,
            LogicApp.Resources.AppResources.DescriptionGroup5,
            LogicApp.Resources.AppResources.DescriptionGroup6,
            LogicApp.Resources.AppResources.DescriptionGroup7,
            LogicApp.Resources.AppResources.DescriptionGroup8
        };

        public static Color[] GroupColors =
        {
            Color.FromHex("1b8b38"),
            Color.FromHex("1b8b38"),
            Color.FromHex("4c51ac"),
            Color.FromHex("4c51ac"),
            Color.FromHex("4c51ac"),
            Color.FromHex("bc5964"),
            Color.FromHex("bc5964"),
            Color.FromHex("bc5964")
        };

        public static Color[] SubgroupColors =
        {
            Color.FromHex("f4f9f5"),
            Color.FromHex("f4f9f5"),
            Color.FromHex("f4f4f9"),
            Color.FromHex("f4f4f9"),
            Color.FromHex("f4f4f9"),
            Color.FromHex("fff7f8"),
            Color.FromHex("fff7f8"),
            Color.FromHex("fff7f8")
        };

        public static String[][][] GroupImages =
        {
            new string[][] // Group 1
            {
                new string[] // 1
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 9
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 10
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 11
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport"
                },
                new string[] // 12
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 13
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 14
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport"
                },
                new string[] // 15
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 16
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 17
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 18
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                }
            }, // End group 1
            new string[][] // Group 2
            {
                new string[] // 1
                {
                    "ability", "absence", "accent", "acceptance", "access", "accident", "accomplishment", "account", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "zone", "youth", "youngster", "yield", "year", "yard", "writing", "writer", "zone",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 9
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 10
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 11
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 12
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport"
                },
                new string[] // 13
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 14
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport"
                },
                new string[] // 15
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 16
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 17
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport"
                },
                new string[] // 18
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                }
            }, // End group 2
            new string[][] // Group 3
            {
                new string[] // 1
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                }
            }, // End group 3
            new string[][] // Group 4
            {
                new string[] // 1
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                }
            }, // End group 4
            new string[][] // Group 5
            {
                new string[] // 1
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 9
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 10
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 11
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 12
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                }
            },
            new string[][] // Group 6
            {
                new string[] // 1
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 9
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 10
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 11
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 12
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                }
            }, // End of group 6
            new string[][] // Group 7
            {
                new string[] // 1
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 9
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 10
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 11
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 12
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport"
                }
            }, // End of group 7
            new string[][] // Group 8
            {
                new string[] // 1
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 2
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 3
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 4
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 5
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport"
                },
                new string[] // 6
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 7
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport"
                },
                new string[] // 8
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport", "sport"
                },
                new string[] // 9
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport"
                },
                new string[] // 10
                {
                    "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport", "sport",
                    "sport"
                }
            } // End of group 8
        };

        public static string[][] SubgroupNames = new string[][]
        {
            new string[] // Group 1
            {
                LogicApp.Resources.AppResources.sgSport,
                LogicApp.Resources.AppResources.sgApparelFood,
                LogicApp.Resources.AppResources.sgArt + " 1/2",
                LogicApp.Resources.AppResources.sgArt + " 2/2",
                LogicApp.Resources.AppResources.sgSociety,
                LogicApp.Resources.AppResources.sgNature,
                LogicApp.Resources.AppResources.sgProfessions,
                LogicApp.Resources.AppResources.sgCharacteristics,
                LogicApp.Resources.AppResources.sgEconomics,
                LogicApp.Resources.AppResources.sgTransportation,
                LogicApp.Resources.AppResources.sgMedicine,
                LogicApp.Resources.AppResources.sgEducation,
                LogicApp.Resources.AppResources.sgScience,
                LogicApp.Resources.AppResources.sgPolitics,
                LogicApp.Resources.AppResources.sgLegal,
                LogicApp.Resources.AppResources.sgIT,
                LogicApp.Resources.AppResources.sgBuildingsMilitary,
                LogicApp.Resources.AppResources.sgReligionNationalities
            },
            new string[] // Group 2
            {
                LogicApp.Resources.AppResources.sg2_1,
                LogicApp.Resources.AppResources.sg2_1,
                LogicApp.Resources.AppResources.sg2_1,
                LogicApp.Resources.AppResources.sg2_3,
                LogicApp.Resources.AppResources.sg2_3,
                LogicApp.Resources.AppResources.sg2_4,
                LogicApp.Resources.AppResources.sg2_5,
                LogicApp.Resources.AppResources.sg2_81,
                LogicApp.Resources.AppResources.sg2_6,                
                LogicApp.Resources.AppResources.sg2_7,
                LogicApp.Resources.AppResources.sg2_7,
                LogicApp.Resources.AppResources.sg2_8,
                LogicApp.Resources.AppResources.sg2_8,
                LogicApp.Resources.AppResources.sg2_9,
                LogicApp.Resources.AppResources.sg2_10,
                LogicApp.Resources.AppResources.sg2_11,
                LogicApp.Resources.AppResources.sg2_12,
                LogicApp.Resources.AppResources.sg2_12
            },
            new string[] // Group 3
            {
                LogicApp.Resources.AppResources.sg3,
                LogicApp.Resources.AppResources.sg3,
                LogicApp.Resources.AppResources.sg3,
                LogicApp.Resources.AppResources.sg3,
                LogicApp.Resources.AppResources.sg3,
                LogicApp.Resources.AppResources.sg3,
                LogicApp.Resources.AppResources.sg3,
                LogicApp.Resources.AppResources.sg3
            },
            new string[] // Group 4
            {
                LogicApp.Resources.AppResources.sg4,
                LogicApp.Resources.AppResources.sg4,
                LogicApp.Resources.AppResources.sg4,
                LogicApp.Resources.AppResources.sg4,
                LogicApp.Resources.AppResources.sg4,
                LogicApp.Resources.AppResources.sg4
            },
            new string[] // Group 5
            {
                LogicApp.Resources.AppResources.sg5_01,
                LogicApp.Resources.AppResources.sg5_01,
                LogicApp.Resources.AppResources.sg5_01,
                LogicApp.Resources.AppResources.sg4_02,
                LogicApp.Resources.AppResources.sg3_04,
                LogicApp.Resources.AppResources.sg4_06,
                LogicApp.Resources.AppResources.sg4_06,
                LogicApp.Resources.AppResources.sg5_08,
                LogicApp.Resources.AppResources.sg3_09,
                LogicApp.Resources.AppResources.sg5_10,
                LogicApp.Resources.AppResources.sg5_11,
                LogicApp.Resources.AppResources.sg5_12
            },
            new string[] // Group 6
            {
                LogicApp.Resources.AppResources.sg6_01,
                LogicApp.Resources.AppResources.sg6_02,
                LogicApp.Resources.AppResources.sg6_03,
                LogicApp.Resources.AppResources.sg6_04,
                LogicApp.Resources.AppResources.sg6_05,
                LogicApp.Resources.AppResources.sg6_06,
                LogicApp.Resources.AppResources.sg6_07,
                LogicApp.Resources.AppResources.sg6_08,
                LogicApp.Resources.AppResources.sg6_09,
                LogicApp.Resources.AppResources.sg6_10,
                LogicApp.Resources.AppResources.sg6_11,
                LogicApp.Resources.AppResources.sg6_12
            },
            new string[] // Group 7
            {
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_01,
                LogicApp.Resources.AppResources.sg7_11,
                LogicApp.Resources.AppResources.sg7_11
            },
            new string[] // Group 8
            {
                LogicApp.Resources.AppResources.sg8_01,
                LogicApp.Resources.AppResources.sg8_02,
                LogicApp.Resources.AppResources.sg8_03,
                LogicApp.Resources.AppResources.sg8_04,
                LogicApp.Resources.AppResources.sg8_05,
                LogicApp.Resources.AppResources.sg8_06,
                LogicApp.Resources.AppResources.sg8_07,
                LogicApp.Resources.AppResources.sg8_08,
                LogicApp.Resources.AppResources.sg8_09,
                LogicApp.Resources.AppResources.sg8_10
            }
        };

        public static string[][] SubgroupURLImages = new string[][]
        {
            new string[] // Group 1 
            {
                "icon_sport",
                "icon_food",
                "icon_music",
                "icon_music",
                "icon_society",
                "icon_nature",
                "icon_profession1",
                "icon_profession2",
                "icon_economics",
                "icon_transportation",
                "icon_medicine",
                "icon_profession3",
                "icon_science1",
                "icon_politics",
                "icon_science2",
                "icon_science3",
                "icon_building",
                "icon_religion"
            },
            new string[] // Group 2
            {
                "icon_2_01",
                "icon_2_01",
                "icon_2_01",
                "icon_2_04",
                "icon_2_04",
                "icon_2_06",
                "icon_2_07",
                "icon_2_08",
                "icon_2_09",
                "icon_2_10",
                "icon_2_10",
                "icon_2_12",
                "icon_2_12",
                "icon_2_14",
                "icon_2_15",
                "icon_2_16",
                "icon_2_17",
                "icon_2_17"
            },
            new string[] // Group 3
            {
                "icon_3",
                "icon_3",
                "icon_3",
                "icon_3",
                "icon_3",
                "icon_3",
                "icon_3",
                "icon_3"
            },
            new string[] // Group 4
            {
                "icon_4",
                "icon_4",
                "icon_4",
                "icon_4",
                "icon_4",
                "icon_4"
            },
            new string[] // Group 5
            {
                "icon_5_01",
                "icon_5_01",
                "icon_5_01",
                "icon_5_04",
                "icon_5_05",
                "icon_5_06",
                "icon_5_06",
                "icon_5_08",
                "icon_5_09",
                "icon_5_10",
                "icon_5_11",
                "icon_5_12"
            },
            new string[] // Group 6
            {
                "icon_6_01",
                "icon_6_02",
                "icon_6_03",
                "icon_6_03",
                "icon_6_05",
                "icon_6_05",
                "icon_6_07",
                "icon_6_07",
                "icon_6_09",
                "icon_6_09",
                "icon_6_11",
                "icon_6_11"
            },
            new string[] // Group 7
            {
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7",
                "icon_7"
            },
            new string[] // Group 8
            {
                "icon_8_01",
                "icon_8_02",
                "icon_8_03",
                "icon_8_04",
                "icon_8_05",
                "icon_8_06",
                "icon_8_07",
                "icon_8_09",
                "icon_8_09",
                "icon_8_09"
            }
        };
    }
}
