#include <iostream>
#include "SuperHero.h"
#include "../LinuxHelperBot/Collection.h"
using namespace std;

int main()
{

    SuperHero s("Captain America", "Super Soldier Serum", "Steve Rodgers", 95);
    SuperHero hulk;

    Collection<SuperHero> league;
    Collection<int> nums;
    league.Add(s);
    nums.Add(1);
    nums.Add(2);
    nums.Add(3);


    cout << s << endl;
    s.RevealSecretIdentity();
    cout << "After Reveal: " << s << endl;
    cout << "********************" << endl;

    hulk.set_name("Incredible Hulk");
     league.Add(hulk);

     cout << hulk << endl;
     cout << "********************" << endl;
     cout << league;

     //cout << league.IndexOf(hulk);
    return 0;
}
