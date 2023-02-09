int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
bool friend = true;
int time = 0;

while(distance > 10)
{
    if(friend == true)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = true;        
    }

    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = false;
    }
    
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");
