using System;

public class CarViewModel
{
	public CarViewModel(Car car)
	{
		_car = car;
	}

	private Car _car { get; set; }

	public string Brand { get { return _car.Brand; } }
	public string Model { get { return _car.Model; } }
	public int HorsePower { get { return _car.HorsePower; } }

	public string Text { get { return Brand + " " + Model + " ("+ HorsePower + " PS)"; } }

	public string PowerClass 
	{ 
		get 
		{
			if(HorsePower <= 50)
			{
				return "schwach";
			}
			else if(HorsePower > 50 && HorsePower < 100)
			{
				return "normal";
			}
			return "stark";
		}
	}

	public bool IsValid {
		get
		{
			return string.IsNullOrEmpty(Brand) && string.IsNullOrEmpty(Model) && HorsePower > 0;
		} 
	}

}
