// See https://aka.ms/new-console-template for more information

Console.WriteLine("Sound Is player");




new Client().Start();







// new Solution().IsPalindrome(121);
//
// public class Solution {
//     public bool IsPalindrome(int x) {
//         x.f  adfefef
//     }
// }











public class SingletonSoundPlayer
{
    // automatic property
    public int soundVolume { get; set; } = 100;

    // property with backing field
    private int _pitch = 100;
    public int pitch {
        get
        {
            return _pitch;
        }
        set
        {
            value = Math.Clamp(value, 0, 100);
            _pitch = value;
        }
    }
    
    private SingletonSoundPlayer()
    {
    }

    // public int GetPitch()
    // {
    //     return pitch;
    // }
    // public void SetPitch(int value)
    // {
    //     value = Math.Clamp(value, 0, 100);
    //     pitch = value;
    // }


    private static SingletonSoundPlayer _instance;
    public static SingletonSoundPlayer Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonSoundPlayer();
            }
            return _instance;
        }
    }
    
    public void Play()
    {
        Console.WriteLine("Playing Sound soundVolume: " + soundVolume);
    }
}


public class Client
{
    public void Start()
    {
        SingletonSoundPlayer.Instance.pitch = 100;
    }
}















