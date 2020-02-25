#pragma once
#include "Person.h"

class BaseballPlayer : public Person
{
	// In this example, we're making our members public for simplicity
public:
	double m_battingAverage;
	int m_homeRuns;

	BaseballPlayer(double battingAverage = 0.0, int homeRuns = 0)
		: m_battingAverage(battingAverage), m_homeRuns(homeRuns)
	{

	}
};

