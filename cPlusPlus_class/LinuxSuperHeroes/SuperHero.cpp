#include "SuperHero.h"

 SuperHero::~SuperHero()
{

}

 SuperHero::SuperHero(string name, string power, string secret, int age)
{
_name = name;
_power = power;
_secret = secret;
_age = age;
}
ostream& operator<<(ostream& out, SuperHero& s)
{
    //out << s._name << endl;
    out << s._name;
}

bool operator>(SuperHero& hero1, SuperHero& hero2)
{
    return (hero1._power_level > hero2._power_level);
}
bool operator<(SuperHero& hero1, SuperHero& hero2)
    {
        return (hero1._power_level < hero2._power_level);
    }
bool operator==(SuperHero& hero1, SuperHero& hero2)
{
    return (hero1._power_level == hero2._power_level);
}
void operator=(SuperHero& hero1, SuperHero& hero2)
    {
        hero1._name = hero2._name;
        hero1._power = hero2._power;
        hero1._secret = hero2._secret;
        hero1._age = hero2._age;
        hero1._power_level = hero2._power_level;
    }
 SuperHero::SuperHero()
{
_name = "unknown";
_power = "classified";
_secret = "classified";
_age = -1;
}

void SuperHero::RevealSecretIdentity()
{
    _name = _secret;
}

void SuperHero::set_age(int age)
{
_age = age;
}
void SuperHero::set_power_level(int power_level)
{
_power_level = power_level;
}

void SuperHero::set_secret(string secret)
{
_secret = secret;
}

void SuperHero::set_power(string power)
{
_power = power;
}

void SuperHero::set_name(string name)
{
_name = name;
}

int SuperHero::age()
{
    return _age;
}

string SuperHero::secret()
{
    return _secret;
}

string SuperHero::power()
{
    return _power;
}

string SuperHero::name()
{
    return _name;

}

