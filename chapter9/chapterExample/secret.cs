public class Box {
    private string _secret = "Sometimes I sing Aretha Franklin songs in the shower.";

    public string GetSecret(string magicWord) {
        if (magicWord == "please") {
            return _secret;
        } else {
            return "I'm not telling you!";
        }
    }



}