//5. Gün

using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKredisiManager = new KonutKredisiManager();
IKrediManager esnafKrediManager = new EsnafKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
//basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseLoggerService);
//basvuruManager.BasvuruYap(konutKredisiManager, fileLoggerService);
//basvuruManager.BasvuruYap(tasitKrediManager, new DatabaseLoggerService());
//basvuruManager.BasvuruYap(esnafKrediManager, new FileLoggerService());
basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });



List<IKrediManager> krediManagers = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, konutKredisiManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);
