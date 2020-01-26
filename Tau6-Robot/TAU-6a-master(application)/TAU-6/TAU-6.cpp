#include <iostream>
#include <vector>
#include <algorithm>
#include "strings_pl.cpp"

bool checkIfSidesNotZero(const std::vector<int>& parameters)
{
	for (auto& i : parameters)
	{
		if (i == 0)
		{
			return false;
		}
	}
	
	return true;
}

void checkTriangles(const std::vector<int>& parameters)
{
	if (!checkIfSidesNotZero(parameters))
	{

		std::cout << s_unrecognized << std::endl;
		return;
	}
	

	int a = parameters.at(0);
	int b = parameters.at(1);
	int c = parameters.at(2);

	// Is it a triangle?

	if (a + b > c && b + c > a && c + a > b)
	{
		if (a == b && b == c)
		{
			std::cout << s_result_is << s_equilateral_triangle << std::endl;
		}

		else if ((a == b && b != c) || (b == c && c != a) || (c == a && a != b))
		{
				std::cout << s_result_is << s_isosceles_triangle << std::endl;
		}

		else
		{
			std::cout << s_result_is << s_polygonal_triangle << std::endl;
		}
	}

	else
	{
		std::cout << s_unrecognized << std::endl;
	}
}

void checkQuadrangles(const std::vector<int>& parameters)
{

	if (!checkIfSidesNotZero(parameters))
	{
		std::cout << s_unrecognized << std::endl;
		return;
	}

	int a = parameters.at(0);
	int b = parameters.at(1);
	int c = parameters.at(2);
	int d = parameters.at(3);

	// 0 values are not allowed

	if (a == b && b == c && c == d)
	{
		std::cout << s_result_is << s_square << std::endl;
	}

	else if (a == c && b == d)
	{
		std::cout << s_result_is << s_rectangle << std::endl;
	}

	else if (a + b + c > d && b + c + d > a && c + d + a > b && d + a + b > c)
	{
		std::cout << s_result_is << s_quadrangle << std::endl;
	}

	else
	{
		std::cout << s_unrecognized << std::endl;
	}
}


int main()
{
	int parameters_limit;
	std::vector<int> parameters;
	int parameter;

	bool APP_RUN = true;

	std::cout << s_separator << std::endl;
	std::cout << s_welcome << std::endl;
	std::cout << s_separator << std::endl;

	while (APP_RUN == true)
	{
		std::cout << s_give_side_count;
		std::cin >> parameters_limit;
		std::cin.clear();

		if (parameters_limit == 0)
		{
			APP_RUN = false;
			break;
		}

		while (parameters_limit < 3 || parameters_limit > 4)
		{
			std::cout << s_wrong_side_count << std::endl;
			std::cout << s_give_side_count;
			std::cin >> parameters_limit;

			if (parameters_limit == 0)
			{
				APP_RUN = false;
				break;
			}
			std::cin.clear();
		}

		for (int i = 0; i < parameters_limit; i++)
		{
			std::cout << s_give_side_value << s_count[i] << s_side;
			std::cin >> parameter;
			std::cin.clear();

			if (parameter == 0 || std::cin.fail())
			{
				std::cin.clear();
				std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
				i--;
				std::cout << s_wrong_side_value << std::endl;
			}

			parameters.push_back(parameter);
		}

		if (parameters.size() == 3)
		{
			checkTriangles(parameters);
		}

		else if (parameters.size() == 4)
		{
			checkQuadrangles(parameters);
		}

		else
		{
			std::cout << s_unrecognized << std::endl;
		}

		parameters.clear();
		
		std::cout << s_separator << std::endl;

	}

	return 0;
}