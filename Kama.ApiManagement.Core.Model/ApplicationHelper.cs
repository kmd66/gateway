namespace Kama.ApiManagement.Core.Model;


public enum ApplicationEnum : int
{
	Unknown = 0,
	سامانه_خدمات = 1,
	سامانه_آموزش = 2,
	سامانه_مدیریت_اطلاعات_پرداخت_کارکنان_نظام_اداری = 3,
	سامانه_استخدام_و_بکارگیری_نیروی_انسانی = 4,
	سامانه_ارزیابی_توسعه_شایستگی_های_عمومی_مدیران_حرفه_ای = 5,
	سامانه_ثبت_حقوق_و_مزایای_کارکنان = 6,
	سامانه_شورای_عالی_اداری = 7,
	سامانه_احراز_هویت_مرکزی = 8,
	سامانه_نظرسنجی = 9,
	گزارش_ها_و_داشبوردهای_سامانه_کارمند_ایران = 10,
	سامانه_سند_برنامه_نیروی_انسانی = 11,
	پایگاه_اطلاعات_کارکنان_نظام_اداری = 12,
	سامانه_ملی_مدیریت_ساختار_دستگاه‌های_اجرایی_کشور = 13,
	پایگاه_اطلاعات_مدیران_دستگاه_های_اجرایی = 14,
	سامانه_مدیریت_مشاغل = 15,
	سامانه_مدیریت_اطلاعات_پایه_سینا = 16,
	اپلیکیشن_سینا = 17
}

public static class ApplicationHelper
{
	public static ApplicationEnum GetApplicationEnum(Guid applicationID)
	{
		switch (applicationID.ToString())
		{
			case "45e64a6e-1f8b-4ba3-942a-f18cf020c3ad": return ApplicationEnum.سامانه_خدمات;
			case "6335dae2-fc8d-421c-b382-d2e513c8d3d6": return ApplicationEnum.سامانه_آموزش;
			case "abdb7e65-b3fb-442a-801a-b7b319efc18b": return ApplicationEnum.سامانه_مدیریت_اطلاعات_پرداخت_کارکنان_نظام_اداری;
			case "a24bd4b0-8bb6-4243-9c95-ae28fb9b24bb": return ApplicationEnum.سامانه_استخدام_و_بکارگیری_نیروی_انسانی;
			case "f4249b0e-0eff-410b-bf45-ae234289cffc": return ApplicationEnum.اپلیکیشن_سینا;
			case "73bd5c30-1530-438c-9872-acd87ea5fe0e": return ApplicationEnum.سامانه_ارزیابی_توسعه_شایستگی_های_عمومی_مدیران_حرفه_ای;
			case "d1b19fe0-1ebc-4546-bbab-7bf634c46267": return ApplicationEnum.سامانه_ثبت_حقوق_و_مزایای_کارکنان;
			case "5cc715e1-d6b0-43b3-b47e-720ace0cf104": return ApplicationEnum.سامانه_شورای_عالی_اداری;
			case "e1d08880-17b0-4127-9ea9-6029dc606b2b": return ApplicationEnum.سامانه_احراز_هویت_مرکزی;
			case "c595819d-32e3-415d-af84-50883d7615be": return ApplicationEnum.سامانه_نظرسنجی;
			case "1cb2b910-6d6d-4d8d-a436-2b9b0c4e69ed": return ApplicationEnum.گزارش_ها_و_داشبوردهای_سامانه_کارمند_ایران;
			case "8900f736-50c8-43e8-84bc-2b7c3945cff1": return ApplicationEnum.سامانه_سند_برنامه_نیروی_انسانی;
			case "e29cbf9d-77df-4fcf-a660-0af295ddf93f": return ApplicationEnum.پایگاه_اطلاعات_کارکنان_نظام_اداری;
			case "1b38c1be-a63e-481b-8d7c-074a64d35fcd": return ApplicationEnum.سامانه_ملی_مدیریت_ساختار_دستگاه‌های_اجرایی_کشور;
			case "5b9d2525-ca2c-470b-b0d6-043f7c218a42": return ApplicationEnum.پایگاه_اطلاعات_مدیران_دستگاه_های_اجرایی;
			case "70d4ddfb-0b3b-4b1f-953a-042afcd3a08e": return ApplicationEnum.سامانه_مدیریت_مشاغل;
			case "6448c892-f0c7-4002-b139-011cb2e57d14": return ApplicationEnum.سامانه_مدیریت_اطلاعات_پایه_سینا;
			default: return ApplicationEnum.Unknown;
		}
	}
}