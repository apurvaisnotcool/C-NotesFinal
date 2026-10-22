namespace _007Dictionary;

class Program
{
    private enum ResourceType
    {
        Stone,
        Wood,
        Gold,
    }

    private enum SkillType
    {
        Attack,
        Dash,
        Defense,
    }
    static void Main(string[] args)
    {
        Dictionary<ResourceType, int> resourceTypeAmountDictionary = new Dictionary<ResourceType, int>();
        /*
         * this is how you construct a dictionary
         * This is a Dictionary where Enum ResourceType is the Key and it holds int values
         */
        
        
        //This is how you add values to the Dictionary. Here Key Stone has int value 56
        resourceTypeAmountDictionary.Add(ResourceType.Stone, 56);
        int dictionaryValueStone = resourceTypeAmountDictionary[ResourceType.Stone];
        //This is how you read value of the Dictionary.Like an Array
        Console.WriteLine(dictionaryValueStone);
        
        
        
        //Adding Another Value
        resourceTypeAmountDictionary[ResourceType.Wood] = 100;
        int dictionaryValueWood = resourceTypeAmountDictionary[ResourceType.Wood];
        Console.WriteLine(dictionaryValueWood);
        
        
        
        //We can Update a value of the key just like an Array
        resourceTypeAmountDictionary[ResourceType.Wood] = 70;
        Console.WriteLine($"Now the Wood Value is {resourceTypeAmountDictionary[ResourceType.Wood]}");
       
        
        //ContainsKey Method returns Bool value(true or false) if the key has a value or not
        bool checkIfKeyPresent = resourceTypeAmountDictionary.ContainsKey(ResourceType.Gold);
        Console.WriteLine(checkIfKeyPresent);
        Console.WriteLine("..................");
        
        
        /*
         TryGetValue: safely checks if the key ResourceType.Gold exists in your dictionary.
                      If it does, it retrieves its value, assigns it to the variable goldAmout,
                      and prints it to the console.
        */
        
        /*
         * out: This method usually return only one value (in this case, a bool indicating success or failure).
         *      The out keyword allows a method to pass an extra result back to the caller through one of its parameters.
         *      i'll explain out in details later don't worry if you didn't understand
         */
        
        if (resourceTypeAmountDictionary.TryGetValue(ResourceType.Gold, out int goldAmount))
        {
            Console.WriteLine(goldAmount);
        }//This code did not run because ResourceType.Gold Does not have a value

        
        
        resourceTypeAmountDictionary.Remove(ResourceType.Gold);
        //This removes the key-Value Pair Gold from the entire Dictionary
        
        
        //We can Directly Assign Values to the Dictionary While we Construct the Dictionary
        Dictionary<SkillType, int> skillTypeAmountDictionary = new Dictionary<SkillType, int>()
        {
            { SkillType.Attack , 10},
            { SkillType.Dash , 20},
            { SkillType.Defense , 30},
        };
        //This is how we Directly Assign Values to the Key value Pairs
        
        
        //We can Cycle through the Dictionary use KeyValuePair
        foreach (KeyValuePair<SkillType, int> pair in skillTypeAmountDictionary)
        {
            Console.WriteLine($"Skill type key: {pair.Key}, value: {pair.Value}");
        }


        Console.WriteLine(".........................");
        //Another Way to Cycle. Here we Cycle using the Key in keyvaluepair
        foreach (SkillType skillType in skillTypeAmountDictionary.Keys)
        {
            Console.WriteLine($"Skill type key: {skillType}, value: {skillTypeAmountDictionary[skillType]}");
        }
        
        
    }
}