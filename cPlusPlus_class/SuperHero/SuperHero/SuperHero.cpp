#include "SuperHero.h"
SuperHero::SuperHero()
{
	last_name_ = "";
	first_name_ = "";
	power_ = "";
	name_ = "";
}
SuperHero::SuperHero( string vfirst, string vlast_name,string vpower, string vname)
{
	last_name_ = vlast_name;
	first_name_ = vfirst;
	power_ = vpower;
	name_ = vname;
}
string SuperHero::last_name()
{
	return last_name_;
}
string SuperHero::first_name()
{
	return first_name_;
}

string SuperHero::power()
{
	return power_;
}
string SuperHero::name()
{
	return name_;
}
	//mutators
	void SuperHero:: set_first_name(string first_name)
	{
		first_name_ = first_name;
	}
	void SuperHero:: set_last_name(string last_name)
	{
		last_name_ = last_name;
	}

	void SuperHero:: set_power(string power)
	{
		power_ = power;
	}
	void SuperHero:: set_name(string name)
	{
		name_ = name;
	}