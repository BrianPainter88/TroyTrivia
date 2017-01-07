using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroyTrivia.Business.Infrastructure
{
    public class BaseTableStructure
    {
        private const string _locationsTable = @"
        CREATE TABLE IF NOT EXISTS [Locations] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
            [Name] VARCHAR(50) NOT NULL,
            [Phone] VARCHAR(128) NULL
        )";

        private const string _addressesTable = @"
        CREATE TABLE IF NOT EXISTS [Addresses] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
            [Address1] VARCHAR(100) NULL,
			[Address2] VARCHAR(100) NULL,
			[City] VARCHAR(50) NULL,
			[State] VARCHAR(15) NULL,
			[ZipCode] VARCHAR(20) NULL,
			[SpecialDirections] VARCHAR(255) NULL,
			[_LocationId] INTEGER NOT NULL
        )";

        private const string _questionsTable = @"
        CREATE TABLE IF NOT EXISTS [Questions] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
			[QuestionText] VARCHAR(255) NULL,
            [_QuestionTypeId] INTEGER NOT NULL,
			[_QuestionDifficultyId] INTEGER NOT NULL,
			[_CategoryId] INTEGER NOT NULL
        )";

        // Lookup Table
        private const string _questionTypesTable = @"
        CREATE TABLE IF NOT EXISTS [QuestionTypes] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
			[Type] VARCHAR(20) NOT NULL
        )";

        // Lookup Table
        private const string _questionDifficultyTable = @"
        CREATE TABLE IF NOT EXISTS [QuestionDifficulty] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
			[Difficulty] VARCHAR(20) NOT NULL
        )";

        // Lookup Table
        private const string _categoriesTable = @"
        CREATE TABLE IF NOT EXISTS [Categories] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
			[Name] VARCHAR(50) NOT NULL
        )";

        private const string _answerKeysTable = @"
        CREATE TABLE IF NOT EXISTS [AnswerKeys] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
			[Text] VARCHAR(255) NULL,
            [Description] VARCHAR(255) NULL,
			[Order] INTEGER NULL,
			[_QuestionId] INTEGER NOT NULL
        )";



        // Storage Table
        private const string _questionHistoryTable = @"
        CREATE TABLE IF NOT EXISTS [QuestionHistory] (
            [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
			[DateUsed] TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
			[_LocationId] INTEGER NOT NULL
        )";

        // QuestionTypes Base Data
        private const string _questionTypesBaseData = @"
		INSERT INTO [QuestionTypes] (Id, Type) VALUES (1, 'True/False');
		INSERT INTO [QuestionTypes] (Id, Type) VALUES (2, 'Ordered');
		INSERT INTO [QuestionTypes] (Id, Type) VALUES (3, 'Standard');
	";

        // QuestionDifficulty Base Data
        private const string _questionDifficultyBaseData = @"
		INSERT INTO [QuestionDifficulty] (Id, Difficulty) VALUES (1, 'Easy');
		INSERT INTO [QuestionDifficulty] (Id, Difficulty) VALUES (2, 'Medium');
		INSERT INTO [QuestionDifficulty] (Id, Difficulty) VALUES (3, 'Hard');
	";

        public static IEnumerable<string> baseTables = new List<string>
    {
        _locationsTable,
        _addressesTable,
        _questionsTable,
        _questionTypesTable,
        _questionDifficultyTable,
        _answerKeysTable,
        _questionHistoryTable,
        _categoriesTable
    };

        public static IEnumerable<string> baseTableData = new List<string>
    {
        _questionTypesBaseData,
        _questionDifficultyBaseData
    };
    }
}
