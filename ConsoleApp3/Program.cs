using System;

namespace Lesson2 {
  class Document {
    public string Name;
    public string Author;
    public string Keyword;
    public string Themes;
    public string PathInFile;
    public Document() {
      Name       = "Я коренной файл";
      Author     = "Я сам себя создал";
      Keyword    = "ЪУЪ";
      Themes     = "All your base are belong to us";
      PathInFile = "У самурая нет цели, только путь";
    }
    public static void Print(Document Оbj) {
      Console.WriteLine($"ИМЯ:            {Оbj.Name}      \n" +
                        $"Автор:          {Оbj.Author}    \n" +
                        $"Ключевое стово: {Оbj.Keyword}   \n" +
                        $"Тема:           {Оbj.Themes}    \n" +
                        $"Путь:           {Оbj.PathInFile}\n");
    }
  }
  class MSWord : Document {
    public MSWord() {
      Name       = "Курсовая";
      Author     = "Воронков Д.А.";
      Keyword    = "Пока не готово";
      Themes     = "Нейронные сети";
      PathInFile = "C:\\Users\\voronkov\\OneDrive\\Рабочий стол";
    }
    public static MSWord MSWordFile;
  }
  class TXT : Document {
    public TXT() {
      Name       = "Чит коды ГТА";
      Author     = "Воронков Д.А.";
      Keyword    = "Читерить ПЛОХО!!!";
      Themes     = "Читы";
      PathInFile = "C:\\Users\\voronkov\\OneDrive\\Рабочий стол\\Просто папка";
    }
    public static TXT TXTFile;
  }
  class MSExcel : Document {
    public MSExcel() {
      Name       = "Считаем доходы и расходы";
      Author     = "Воронков Д.А.";
      Keyword    = "ГДЕ ДЕНЬГИ?!";
      Themes     = "Финансы";
      PathInFile = "C:\\Users\\voronkov\\OneDrive\\Рабочий стол\\Секретные документы КГБ";
    }
    public static MSExcel MSExcelFile;
  }

  class PDF : Document {
    public PDF() {
      Name       = "Моё фото";
      Author     = "Воронков Д.А.";
      Keyword    = "Лучше сделай новое";
      Themes     = "Фотография";
      PathInFile = "C:\\Users\\voronkov\\OneDrive\\Рабочий стол\\Секретные документы КГБ\\Фото";
    }
    private static PDF PDFFile;
  }

  class HTML : Document {
    public HTML() {
      Name       = "Название потом придумаю";
      Author     = "Воронков Д.А.";
      Keyword    = "Какой-то набор тегов";
      Themes     = "HTML документ";
      PathInFile = "C:\\Users\\voronkov\\OneDrive\\Рабочий стол\\Просто папка";
    }
    private static HTML HTMLFile;
  }
  class Singleton {
    public static Singleton Instance {
      get
      {
        if (instance == null) instance = new Singleton();
        return instance;
      }
    }
    private Singleton() { }
    private static Singleton instance;
    public void Create(string Number) {
      Document Doc;

      switch (Number) {
        case "1": {
          Doc = new TXT();
          break;
        }
        case "2": {
          Doc = new MSExcel();
          break;
        }
        case "3": {
          Doc = new PDF();
          break;
        }
        case "4": {
          Doc = new HTML();
          break;
        }
        case "5": {
          Doc = new MSWord();
          break;
        }
        default: {
          Doc = new Document();
          break;
        }
      }
      Document.Print(Doc);
    }
  }
  class HelloWorld {
    static void Main() {
      while (true) {
        Console.WriteLine("Выбери файл: \n[1] - TXT"     +
                                       "\n[2] - MSExcel" +
                                       "\n[3] - PDF"     +
                                       "\n[4] - HTML"    +
                                       "\n[5] - MSWord\n");
        Singleton.Instance.Create(Console.ReadLine());
      }
    }
  }
}