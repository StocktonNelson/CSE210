public class PromptGenerator
{
    private List<string> prompts;

    private Random random = new Random();

    //* when we add add a list of prompts then it should pick one out that we will use.
    //* has ai make the randoms for me to save time
    public PromptGenerator()
    {
        prompts = new List<string>
    {
        "What is your favorite memory from childhood?",
        "Describe a time when you felt truly happy.",
        "What are you most grateful for today?",
        "What is your biggest goal for this year?",
        "Who has been the most influential person in your life?",
        "What is your favorite book and why?",
        "Describe a place you have always wanted to visit.",
        "What is your favorite hobby and how did you get into it?",
        "What is the most challenging thing you have ever done?",
        "What is your favorite way to relax?",
        "Describe a time when you helped someone in need.",
        "What is your favorite movie and why?",
        "What is the best piece of advice you have ever received?",
        "What is your favorite holiday and how do you celebrate it?",
        "What is your dream job and why?",
        "Describe a time when you overcame a fear.",
        "What is your favorite family tradition?",
        "What is the most interesting thing you have learned recently?",
        "What is your favorite type of music and why?",
        "Describe a time when you felt proud of yourself.",
        "What is your favorite food and why?",
        "What is the most beautiful place you have ever seen?",
        "What is your favorite season and why?",
        "Describe a time when you made a new friend.",
        "What is your favorite sport and why?",
        "What is the most important lesson you have learned in life?",
        "What is your favorite animal and why?",
        "Describe a time when you achieved a goal.",
        "What is your favorite thing to do on a weekend?",
        "What is the most memorable trip you have ever taken?",
        "What is your favorite quote and why?",
        "Describe a time when you faced a difficult decision.",
        "What is your favorite thing about yourself?",
        "What is the most fun you have ever had?",
        "What is your favorite way to spend a rainy day?",
        "Describe a time when you learned something new.",
        "What is your favorite childhood memory?",
        "What is the most interesting place you have ever visited?",
        "What is your favorite thing to do with friends?",
        "What is the most valuable lesson you have learned from a mistake?",
        "What is your favorite way to stay active?",
        "Describe a time when you felt truly content.",
        "What is your favorite thing to do in nature?",
        "What is the most inspiring thing you have ever seen?",
        "What is your favorite way to express creativity?",
        "Describe a time when you felt really proud of someone else.",
        "What is your favorite way to spend time with family?",
        "What is the most important goal you have for the future?",
        "What is your favorite way to unwind after a long day?"
    };
    }
    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
    
}