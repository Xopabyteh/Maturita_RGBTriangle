//Twice same color = same color on \n
//Different color = other color on \n

/*
    RG => B
    RBRGBRB => G
    R R G B R G B B => G
*/

using System.Text;

Console.WriteLine(EvaluateTriangle("RG"));
Console.WriteLine(EvaluateTriangle("RBRGBRB"));
Console.WriteLine(EvaluateTriangle("RRGBRGBB"));


char EvaluateTriangle(string sequence)
{
    //We've reached the tip of the triangle
    if (sequence.Length == 1)
    {
        return sequence[0];
    }

    StringBuilder newLineBuilder = new StringBuilder();
    //Go through all character tuples
    for (int i = 0; i < sequence.Length - 1; i++)
    {
        //Get the char tuple
        string tuple = sequence.Substring(i, 2);
        //If both chars are same -> add same to new line
        if (tuple[0] == tuple[1])
        {
            newLineBuilder.Append(tuple[0]);
            continue;
        }
        //Otherwise add the missing char to the new line
        if (!tuple.Contains("R"))
            newLineBuilder.Append("R");
        else if (!tuple.Contains("B"))
            newLineBuilder.Append("B");
        else if (!tuple.Contains("G"))
            newLineBuilder.Append("G");
    }
    //Recursively send the new line
    return EvaluateTriangle(newLineBuilder.ToString());
}