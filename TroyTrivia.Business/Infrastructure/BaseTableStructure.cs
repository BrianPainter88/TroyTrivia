using System.Collections.Generic;

namespace TroyTrivia.Business.Infrastructure
{
    public class BaseTableStructure
    {
        private const string _locationsTable = @"
        CREATE TABLE IF NOT EXISTS [Locations] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
            [Name] VARCHAR(50) NOT NULL,
            [Phone] VARCHAR(128) NULL
        )";

        private const string _addressesTable = @"
        CREATE TABLE IF NOT EXISTS [Addresses] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
            [Address1] VARCHAR(100) NULL,
			[Address2] VARCHAR(100) NULL,
			[City] VARCHAR(50) NULL,
			[State] VARCHAR(15) NULL,
			[ZipCode] VARCHAR(20) NULL,
			[SpecialDirections] VARCHAR(255) NULL,
			[LocationId] UNIQUEIDENTIFIER NOT NULL
        )";

        private const string _questionsTable = @"
        CREATE TABLE IF NOT EXISTS [Questions] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
			[QuestionText] VARCHAR(255) NULL,
            [QuestionTypeId] UNIQUEIDENTIFIER NOT NULL,
			[QuestionDifficultyId] UNIQUEIDENTIFIER NOT NULL,
			[CategoryId] UNIQUEIDENTIFIER NOT NULL
        )";

        // Lookup Table
        private const string _questionTypesTable = @"
        CREATE TABLE IF NOT EXISTS [QuestionTypes] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
			[Name] VARCHAR(50) NOT NULL
        )";

        // Lookup Table
        private const string _questionDifficultyTable = @"
        CREATE TABLE IF NOT EXISTS [QuestionDifficulty] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
			[Name] VARCHAR(20) NOT NULL
        )";

        // Lookup Table
        private const string _categoriesTable = @"
        CREATE TABLE IF NOT EXISTS [Categories] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
			[Name] VARCHAR(50) NOT NULL
        )";

        private const string _answerKeysTable = @"
        CREATE TABLE IF NOT EXISTS [AnswerKeys] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
			[Text] VARCHAR(255) NULL,
            [Description] VARCHAR(255) NULL,
			[Order] INTEGER NULL,
			[QuestionId] UNIQUEIDENTIFIER NOT NULL
        )";

        private const string _teamsTable = @"
        CREATE TABLE IF NOT EXISTS [Teams] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
            [Name] VARCHAR(255) NULL
        )";

        // Storage Table
        private const string _questionHistoryTable = @"
        CREATE TABLE IF NOT EXISTS [QuestionHistory] (
            [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
			[DateUsed] TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
			[LocationId] UNIQUEIDENTIFIER NOT NULL
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
            _categoriesTable,
            _teamsTable
        };

        public static IEnumerable<string> baseTableData = new List<string>
        {
            _questionTypesBaseData,
            _questionDifficultyBaseData
        };
    }
}
