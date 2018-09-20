using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduktion : MonoBehaviour
{
    // public=visas i unity
    // int=heltal
    //
    // Dessa är viktiga (förutom decimal)
    //public int testInt = 5;

    public float testFloat = 1.0f;

    //public double testDouble = 1.0d;

    ////public decimal testDecimal;

    //public bool testBool = true;

    //public char testChar = 'A';

    //public string testString = "tjenare";
    ////Dessa är inte viktiga
    //public uint testUint;
    //public ulong testUlong;
    //public long testLong;
    //public byte testByte;
    public float angle;
    public float radius;
    public string sentence1;
    public string sentence2;
    public int damage;
    public string sentence3;
    public float number;
    public float bose;
    public new string name;
    public string boss;
    public string ofDoom;
    public int life;
    public int demons;
    public int minDamage;
    public int maxDamage;
    // fu
    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Sentence1();
        Uppgift3();
        Uppgift4();
        Uppgift6();
        Uppgift5();
        Uppgift7();
        Uppgift8();
    }
    void Uppgift1()
    {

        Debug.Log(
            string.Format(
                "Svaret på (963 * 421) - (175463 / 87) är {0}"
                , (963f * 421f) - (175463 / 87)));
    }
    void Uppgift3()
    {
        Debug.Log(string.Format("Talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} blir {2}", number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
            
        
    } void Uppgift4()
    {
        Debug.Log(string.Format("Triangelns area är basen {0}m gånger höjden 8m delat med 2 vilket blir 8m^2", bose));
    } void Uppgift6()
    {
        Debug.Log(string.Format("Boss {0} of Doom", name));
        
    } 
    void Sentence1()
    {
        print(sentence1);
        print(sentence2);
        print(sentence3);
    }
    void Uppgift5()
    {
        Debug.Log(string.Format("om du delar en tåtra i delar med vinkeln {0} så får du {1} delar", angle, (360 / angle)));
    }
    void Uppgift7()
    {
        Debug.Log(string.Format("Volymen på 2978 klot är 4 * π * radien^3 delat på 3 så om radien är {0} är volymen {1}", radius, 4 * 3.14f * radius * radius * radius / 3 * 2978));
    }
    void Uppgift8()
    {
        Debug.Log(string.Format
            ("Antalet attacker som krävs för att döda {3} demoner om en demon har {2} liv är {0} gånger kvoten av {2} * {3} delat med {0} vilket är {1}", damage, life * demons / damage, life, demons));
        Debug.Log(string.Format
            ("Antalet attacker som krävs för att döda {3} demoner om en demon har {2} liv är minst {0} gånger kvoten av {2} * {3} delat med {0} vilket är {1}", minDamage, life * demons / minDamage, life, demons));

        Debug.Log(string.Format
           ("Antalet attacker som krävs för att döda {3} demoner om en demon har {2} liv och en attack gör {0} till {1} {0} gånger kvoten av {2} * {3} delat med {0} vilket är {1}", minDamage, maxDamage, life * demons / maxDamage, life, demons));
    }
    // Update is called once per frame
    void Update()
    {

    }
}






