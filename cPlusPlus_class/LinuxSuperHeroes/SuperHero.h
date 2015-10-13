#ifndef SUPERHERO_H
#define SUPERHERO_H
#include <string>
#include <iostream>
using namespace std;
class SuperHero
{
    public:
    //getters
    string name();
    string power();
    string secret();


    int age();
    //setters
    void set_name(string);
    void set_power(string);
    void set_secret(string);
    void set_power_level(int);
    void set_age(int);
    void RevealSecretIdentity();
    friend ostream& operator<<(ostream&, SuperHero&);
    friend bool operator>(SuperHero&, SuperHero&);
    friend bool operator<(SuperHero&, SuperHero&);
    friend bool operator==(SuperHero&, SuperHero&);
    void operator=(SuperHero&, SuperHero&);

    SuperHero();
     SuperHero(string, string, string, int);
    ~SuperHero();
    protected:
    private:
    //private variables
    string _name;
    string _power;
    string _secret;
    int _age;
    int _power_level;
};

#endif // SUPERHERO_H
