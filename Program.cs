
int size;
Console.WriteLine("enter the text of the word, separate with a space, as soon as you finish typing, press enter");
string? text = Console.ReadLine();
string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
do
{
   Console.WriteLine("Enter the size of the text you want to output - ");
   size = Convert.ToInt32(Console.ReadLine());
   if (size <= 0)
   {
      Console.WriteLine("incorrect data entered");
      Console.Clear();
   }
} while (size <= 0);

string[] word = Array.FindAll(words, word => word.Length <= size);

for (int i = 0; i < word.Length; i++)
{
   Console.Write(word[i] + " ");
}