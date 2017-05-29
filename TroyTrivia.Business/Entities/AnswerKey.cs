using System;
using System.Data;
using Dapper.Contrib.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class AnswerKey
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public Guid QuestionId { get; set; }

        public AnswerKey()
        {
            Order = 1;
            Id = Guid.NewGuid();
        }

        public AnswerKey(Guid questionId) : this()
        {
            QuestionId = questionId;
        }

        public void Insert(IDbConnection connection)
        {
            connection.Insert(this);
            /*
            connection.ExecuteNonQuery(@"
		   		INSERT INTO AnswerKeys ([Text], [Description], [Order], [_QuestionId]) 
				VALUES (@Text, @Description, @Order, @QuestionId);",
                    new { Text = this.Text, Description = this.Description, Order = this.Order, QuestionId = questionId }
                );
            */
        }

        public void Update(IDbConnection connection)
        {
            connection.Update(this);
            /*
            connection.ExecuteNonQuery(
                @"UPDATE [AnswersKeys] SET [Text] = @Text, [Description] = @Description, [Order] = @Order WHERE [Id] = @AnswerKeyId",
                new { Text = this.Text, Description = this.Description, Order = this.Order, AnserKeyId = this.Id }
            );
            */
        }
    }
}
