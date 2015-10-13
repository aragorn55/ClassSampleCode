#include <iostream>

using namespace std;
template <class T>
class Collection
{
private:
	T* _data;
	int _length;
public:
	//constructor
	Collection();
	// destructor
	~Collection();
	//gett for the private _length
	int Length();
	T GetValue(int);
	void Add(T);
	//friend ostream& operator<<(ostream&, Collection&);
	T& operator[](int);
	bool Contains(T);
	int IndexOf(T);
	int LinearSearch(T);

};

template <class T>
Collection<T>::Collection()
{
	_length = 0;
	_data = new T[_length];
	//_data[0] = 0;
}
template <class T>
Collection<T>::~Collection()
{

}
template <class T>
T Collection<T>::GetValue(int index)
{
	// add check to check if index is longer than array
	return _data[index];
}
template <class T>
void Collection<T>::Add(T value)
{
	//declare new array of _length + 1
	T *temp = new T[_length +1];
	//copy old elements into new array
	for (int i = 0; i < _length; i++)
	{
		temp[i] = _data[i];
	}
	//add new value to end of new array
	temp[_length] = value;
	//delete old array to free up memory
	delete[] _data;
	//point _data to new array
	_data = temp;
	_length += 1;
}
template <class T>
int Collection<T>::LinearSearch(T value)
{
    int index = -1;
    for (int i = 0; i < _length; i++)
	{
		if(_data[i] == value)
		{
		    index = i;
		    break;
		}
	}
	else if (_sorted && _data > value)
	{
	    break;
	}
    return index;

}
template <class T>
int Collection<T>::IndexOf(T value)
{
    int index = -1;
    index = this.LinearSearch(value);
    return index;

}
template <class T>
bool Collection<T>::Contains(T value)
{
    return IndexOf(T) > -1;
}
template <class T>
int Collection<T>::Length()
	{
		return _length;
}
template <class T>
ostream& operator<<(ostream &out, Collection<T> &c)
 {
	out << "{";
	for (int i = 0; i < c.Length(); i++)
	{
		if (i > 0) cout <<", ";
		out << c[i];
	}
	out << "}";
	return out;
}
template <class T>
T& Collection<T>::operator[](int index)
	{
		return _data[index];
	}
