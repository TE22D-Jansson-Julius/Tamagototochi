
public class Tomomomomomogatchi
{
private int hunger;
private int boredom;
private List<string> words;
private bool isAlive;
private Random generator;
public string name;


public void Feed(){

}

public void Hi(){

}

public void Teach(){

}

public void Tick(){
hunger += 1;
boredom +=1;

   if (hunger > 10  || boredom > 10){
isAlive = false;
    }
    else isAlive = true;
}

public void  PrintStats(){
 Console.WriteLine("Stats");
 Console.WriteLine(name);
 Console.WriteLine(hunger);
 Console.WriteLine(boredom);
Console.WriteLine(isAlive);
}

public bool GetAlive(){

    return isAlive;
}

private void ReduceBoredom() {

}

}
