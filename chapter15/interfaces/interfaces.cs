using System;

namespace interfaces {
    public interface MothersDay {
        int StemLength { get; set; }
        bool doesItSmellNice{get; set;}


    }
}


// ## Lightning Exercise 2
// We just got some new requirements from the customer. Refactor your flower classes based on the following information:
// Choose the two flowers you want to be in the Mother's Day arrangement and make sure both have a StemLength property. Any flower in this arrangement, even in the future, needs to have a stem length of 5 inches. This means that the StemLength property must exist on those flowers. It can optional on other flowers.
// The other two flowers will be in the wedding arrangement. Flowers in the wedding arrangement will always have some white (!!!!!!!or!!!!!!!) yellow in them. That means that the Color property must be on flowers for that arrangement. It can be optional on other flowers.
