using App1.dataobject;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.model
{
    public class Model
    {
        
        private List<FoodAndWineEntry> foodAndWineEntries;
        public List<FoodAndWineEntry> FoodAndWineEntries { set { foodAndWineEntries = value; } get { return foodAndWineEntries; } }

        private List<AH> ahs;
        public List<AH> AHs {set{ ahs = value;} get{ return ahs; } }

        private List<ShoppingEntry> shoppingEntries;
        public List<ShoppingEntry> ShoppingEntries {set{ shoppingEntries = value; }get { return shoppingEntries; } }

        public Model() {
            FoodAndWineEntries = new List<FoodAndWineEntry>();
            AHs = new List<AH>();
            shoppingEntries = new List<ShoppingEntry>();
            for (int index = 0; index < 16;index++) {
                FoodAndWineEntry temp = new FoodAndWineEntry
                {
                    RestaurantName = "Mr Sushi" + index,
                    ReviewScore = 4.5,
                    Special = "Sushi bars, seafood, Ramen",
                    Address = "1204 n interstate Dr,Ste 130, Norman",
                    Distance = index,
                    MainImage = "https://s3-media4.fl.yelpcdn.com/bphoto/OGcA8vvKqCyDY4IUMydjfA/o.jpg",
                    AveragePrice = 5.3 + index,
                    Description = "But the real star is the food. Tables laden with delicacies line the walls. Everything you can think of, and things you have never dreamed of, lie in wait. Whole roasted cows and pigs and goats still turning on spits. Huge platters of fowl stuffed with savoury fruit and nuts. Ocean creatures drizzled in sauces or begging to be dipped in spicy concoctions. Countless cheeses, breads, vegetables, sweets, waterfalls of wine, and streams of spirits that flicker with flames." + index,
                    ImageList = new List<string> { "https://ss2.bdstatic.com/70cFvnSh_Q1YnxGkpoWK1HF6hhy/it/u=519346092,2976750614&fm=27&gp=0.jpg",
                    "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1523130641138&di=eb7711ba8645b454a315e1defb2b31b5&imgtype=0&src=http%3A%2F%2Fimgsrc.baidu.com%2Fimgad%2Fpic%2Fitem%2Fd53f8794a4c27d1ebf4654ff10d5ad6eddc438ac.jpg",
                    "https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1523130641661&di=2abd404c658770f46e30d11011e84006&imgtype=0&src=http%3A%2F%2Fimgsrc.baidu.com%2Fimage%2Fc0%253Dpixel_huitu%252C0%252C0%252C294%252C40%2Fsign%3D2806cf299cdda144ce0464f2dbcfb5ce%2F91ef76c6a7efce1bb9c7a3f0a451f3deb48f651f.jpg"


                    },
                    PhoneNumber = "405-625-" + (2780 + index),
                    Direction="DIRECTION"
                };

                AH ahtemp = new AH {
                    AttractionName = "chentiangou",
                    AHaddress="wangbadan",
                    AHimageList = new List<string> { "http://www.zfiengr.com/assets/images/OU_Devon_Energy_Hall.jpg" },
                    AHdescription = "OU Devon Energy Hall and Rawl Engineering Practice Facility+/n" +
                    "Norman, Oklahoma+/n" +
                    "The Devon Energy Hall serves as instructional and research space for the College " +
                    "of Engineering at the University of Oklahoma.  The facility has a five-story " +
                    "conventionally-reinforced concrete pan joist and shear wall structural system.  " +
                    "Special design features include a four-story atrium space and a grand stair supported" +
                    " only at the floor levels. The Rawl Engineering Practice Facility consists of hands-on " +
                    "laboratory and testing spaces for the College of Engineering.  The facility has a two-story" +
                    " conventionally-reinforced concrete pan joist and moment frame structural system.  Highlights " +
                    "of the design include a two-story-high practice bay area serviced by a three-ton crane and a " +
                    "centrally located, three-story high, automated storage and retrieval system."

                };
                ShoppingEntry setrmp = new ShoppingEntry {
                    StoreName = "Mr Sushi" + index,
                    ReviewScore = 4.5,
                    Special = "Sushi bars, seafood, Ramen",
                    Address = "1204 n interstate Dr,Ste 130, Norman",
                    ImageList = new List<string> { "http://www.zfiengr.com/assets/images/OU_Devon_Energy_Hall.jpg" },
                    Description = "But the real star is the food. Tables laden with delicacies line the walls. Everything you can think of, and things you have never dreamed of, lie in wait. Whole roasted cows and pigs and goats still turning on spits. Huge platters of fowl stuffed with savoury fruit and nuts. Ocean creatures drizzled in sauces or begging to be dipped in spicy concoctions. Countless cheeses, breads, vegetables, sweets, waterfalls of wine, and streams of spirits that flicker with flames." + index,

                };





                foodAndWineEntries.Add(temp);
                ahs.Add(ahtemp);
                shoppingEntries.Add(setrmp);
            }

        }
    }
}
