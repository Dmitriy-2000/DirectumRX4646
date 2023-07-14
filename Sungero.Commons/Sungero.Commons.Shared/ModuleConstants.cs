﻿using System;

namespace Sungero.Commons.Constants
{
  public static class Module
  {
    /// <summary>
    /// Типы поиска Elasticsearch.
    /// </summary>
    public static class ElasticsearchType
    {
      [Sungero.Core.Public]
      public const string Wildcard = "Wildcard";
      [Sungero.Core.Public]
      public const string Term = "Term";
      [Sungero.Core.Public]
      public const string MatchAnd = "MatchAnd";
      [Sungero.Core.Public]
      public const string MatchOr = "MatchOr";
      [Sungero.Core.Public]
      public const string FuzzyAnd = "FuzzyAnd";
      [Sungero.Core.Public]
      public const string FuzzyOr = "FuzzyOr";
    }
    
    /// <summary>
    /// Значения оценки Elasticsearch, ниже которой результаты нечеткого поиска недостоверны.
    /// </summary>
    public static class ElasticsearchScore
    {
      // Процент от максимально возможной оценки для расчета лимита.
      [Sungero.Core.Public]
      public const double DefaultLimitPercent = 67;
      
      // Минимальная оценка по умолчанию.
      [Sungero.Core.Public]
      public const double DefaultMinLimit = 0.5;
      
      // Число записей с оценкой выше лимита, которое нужно вернуть.
      [Sungero.Core.Public]
      public const int DefaultResultsLimit = 1;
    }
    
    /// <summary>
    /// Шаблон bulk-запроса к целевому индексу Elasticsearch.
    /// </summary>
    [Sungero.Core.Public]
    public const string BulkOperationIndexToTarget = "{\"index\":{}}";
    
    /// <summary>
    /// Максимальное количество записей, получаемых за 1 запрос.
    /// </summary>
    [Sungero.Core.Public]
    public const int MaxQueryIds = 999;

    /// <summary>
    /// Максимальное количество итераций асинхронных обработчиков индексации и удаления из индекса.
    /// </summary>
    public const int IndexingAsyncsRetryCount = 6;
    
    /// <summary>
    /// Имя ключа в параметрах сущности - признак изменения индексируемых полей и того, что сущность создана и еще не сохранена в БД.
    /// </summary>
    [Sungero.Core.Public]
    public const string IsIndexedEntityInsertedParamKey = "IsIndexedEntityInserted";

    /// <summary>
    /// Шаблон имени индекса Elasticsearch.
    /// </summary>
    public const string IndexNameTemplate = "rxsearch_{0}_{1}_{2}";
    
    /// <summary>
    /// Guid модуля Intelligence.
    /// </summary>
    [Sungero.Core.Public]
    public static readonly Guid IntelligenceGuid = Guid.Parse("e08dc659-2828-4d50-b90d-7d06408ab7cb");

    /// <summary>
    /// Шаблон для поиска спец. символов.
    /// </summary>
    public const string SpecialSymbolsPattern = @"\\|\/|\:|\;|\*|\?|\<|\>|\||\'|\`|\«|\»|\“|\”|\(|\)|\[|\]|\{|\}|\^|\%|\!|_|-|""";
    
    /// <summary>
    /// Шаблон для поиска двойных пробелов.
    /// </summary>
    public const string DoubleSpacePattern = " {2,}";
    
    /// <summary>
    /// Имя параметра "Все индексы созданы".
    /// </summary>
    [Sungero.Core.Public]
    public const string AllIndicesExistParamName = "AllIndicesExist";
    
    /// <summary>
    /// Стандартные синонимы ОПФ для индексов ElasticSearch.
    /// </summary>
    [Sungero.Core.Public]
    public const string LegalFormSynonyms = @"
                                                Акционерное общество,АО;
                                                Акционерный коммерческий банк,АКБ;
                                                Автономная некоммерческая организация,АНО;
                                                Агропромышленный холдинг,АПХ;
                                                Автономное учреждение,АУ;
                                                Автономное учреждение культуры,АУК;
                                                Бюджетное учреждение,БУ;
                                                Бюджетное учреждение культуры,БУК;
                                                Государственное автономное образовательное учреждение высшего образования,ГАОУ ВО;
                                                Государственное автономное образовательное учреждение дополнительного профессионального образования,ГАОУ ДПО;
                                                Государственное автономное образовательное учреждение высшего профессионального образования,ГАОУ ВПО;
                                                Государственное автономное образовательное учреждение среднего профессионального образования,ГАОУ СПО;
                                                Государственное автономное профессиональное образовательное учреждение,ГАПОУ;
                                                Государственное автономное учреждение,ГАУ;
                                                Государственное автономное учреждение культуры,ГАУК;
                                                Государственное бюджетное образовательное учреждение,ГБОУ;
                                                Государственное бюджетное образовательное учреждение высшего профессионального образования,ГБОУ ВПО;
                                                Государственное бюджетное образовательное учреждение среднего профессионального образования,ГБОУ СПО;
                                                Государственное бюджетное образовательное учреждение дополнительного профессионального образования,ГБОУ ДПО;
                                                Государственное бюджетное профессиональное образовательное учреждение,ГБПОУ;
                                                Государственное бюджетное учреждение,ГБУ;
                                                Государственное бюджетное учреждение здравоохранения,ГБУЗ;
                                                Государственное бюджетное учреждение культуры,ГБУК;
                                                Государственное краевое бюджетное учреждение,ГКБУ;
                                                Государственное краевое бюджетное учреждение культуры,ГКБУК;
                                                Государственное казенное учреждение,ГКУ;
                                                Государственное казенное учреждение культуры,ГКУК;
                                                Государственное образовательное бюджетное учреждение культуры,ГОБУК;
                                                Государственное образовательное учреждение высшего образования,ГОУ ВО;
                                                Государственное образовательное учреждение высшего профессионального образования,ГОУ ВПО;
                                                Государственное образовательное учреждение среднего профессионального образования,ГОУ СПО;
                                                Государственное образовательное учреждение доплнительного профессионального образования,ГОУ ДПО;
                                                Государственная телерадиокомпания,ГТРК;
                                                Государственное учреждение,ГУ;
                                                Государственное учреждение культуры,ГУК;
                                                Государственное унитарное предприятие,ГУП;
                                                Закрытое акционерное общество,ЗАО;
                                                Индивидуальный предприниматель,ИП;
                                                Краевое государственное автономное учреждение культуры,КГАУК;
                                                Краевое государственное бюджетное научное учреждение культуры,КГБНУК;
                                                Краевое государственное бюджетное учреждение,КГБУ;
                                                Краевое государственное казенное учреждение,КГКУ;
                                                Краевое государственное учреждение,КГУ;
                                                Муниципальное автономное общеобразовательное учреждение,МАОУ;
                                                Муниципальное автономное учреждение,МАУ;
                                                Муниципальное автономное учреждение культуры,МАУК;
                                                Муниципальное бюджетное общеобразовательное учреждение,МБОУ;
                                                Муниципальное бюджетное учреждение,МБУ;
                                                Муниципальное бюджетное учреждение культуры,МБУК;
                                                Муниципальное казенное учреждение,МКУ;
                                                Муниципальное казенное учреждение культуры,МКУК;
                                                Муниципальное учреждение,МУ;
                                                Муниципальное учреждение культуры,МУК;
                                                Научно-исследовательский институт,НИИ;
                                                Негосударственное образовательное учреждение высшего профессионального образования,НОУ ВПО;
                                                Негосударственное образовательное учреждение среднего профессионального образования,НОУ СПО;
                                                Негосударственное образовательное учреждение дополнительного профессионального образования,НОУ ДПО;
                                                Научно-производственное объединение,НПО;
                                                Научно-производственное предприятие,НПП;
                                                Открытое акционерное общество,ОАО;
                                                Областное бюджетное учреждение культуры,ОБУК;
                                                Областное государственное автономное учреждение культуры,ОГАУК;
                                                Областное государственное бюджетное учреждение культуры,ОГБУК;
                                                Областное государственное казенное учреждение культуры,ОГКУК;
                                                Общество с ограниченной ответственностью,ООО;
                                                Публичное акционерное общество,ПАО;
                                                Товарищество с ограниченной ответственностью,ТОО;
                                                Федеральное бюджетное учреждение,ФБУ;
                                                Федеральное государственное автономное образовательное учреждение высшего образования,ФГАОУ ВО;
                                                Федеральное государственное автономное образовательное учреждение высшего профессионального образования,ФГАОУ ВПО;
                                                Федеральное государственное автономное образовательное учреждение среднего профессионального образования,ФГАОУ СПО;
                                                Федеральное государственное автономное образовательное учреждение дополнительного профессионального образования,ФГАОУ ДПО;
                                                Федеральное государственное бюджетное военное образовательное учреждение высшего образования,ФГБВОУ ВО;
                                                Федеральное государственное бюджетное научно-исследовательское учреждение,ФГБНИУ;
                                                Федеральное государственное бюджетное научное учреждение,ФГБНУ;
                                                Федеральное государственное бюджетное образовательное учреждение,ФГБОУ;
                                                Федеральное государственное бюджетное образовательное учреждение высшего профессионального образования,ФГБОУ ВПО;
                                                Федеральное государственное бюджетное образовательное учреждение среднего профессионального образования,ФГБОУ СПО;
                                                Федеральное государственное бюджетное образовательное учреждение дополнительного профессионального образования,ФГБОУ ДПО;
                                                Федеральное государственное бюджетное учреждение,ФГБУ;
                                                Федеральное государственное бюджетное учреждение культуры,ФГБУК;
                                                Федеральное государственное бюджетное учреждение науки,ФГБУН;
                                                Федеральное государственное казенное военное образовательное учреждение,ФГКВОУ;
                                                Федеральное государственное казенное образовательное учреждение,ФГКОУ;
                                                Федеральное государственное образовательное учреждение,ФГОУ;
                                                Федеральное государственное образовательное учреждение высшего профессионального образования,ФГОУ ВПО;
                                                Федеральное государственное образовательное учреждение среднего профессионального образования,ФГОУ СПО;
                                                Федеральное государственное образовательное учреждение дополнительного профессионального образования,ФГОУ ДПО;
                                                Федеральное государственное учреждение,ФГУ;
                                                Федеральное государственное унитарное предприятие,ФГУП;
                                                Федеральное казенное предприятие,ФКП;
                                                Федеральное казенное учреждение,ФКУ;
                                                Федеральное казенное учреждение культуры,ФКУК;
                                                Частная охранная организация,ЧОО;";
  }
}
