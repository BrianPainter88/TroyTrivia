using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TroyTrivia.Business.Extensions;

namespace TroyTrivia.Business.Entities
{
    public class AnswerKey
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }

        public AnswerKey()
        {
            Order = 1;
        }

        public void Insert(IDbConnection connection, int questionId)
        {
            connection.ExecuteNonQuery(@"
		   		INSERT INTO AnswerKeys ([Text], [Description], [Order], [_QuestionId]) 
				VALUES (@Text, @Description, @Order, @QuestionId);",
                    new { Text = this.Text, Description = this.Description, Order = this.Order, QuestionId = questionId }
                );
        }

        public void Update(IDbConnection connection)
        {
            connection.ExecuteNonQuery(
                @"UPDATE [AnswersKeys] SET [Text] = @Text, [Description] = @Description, [Order] = @Order WHERE [Id] = @AnswerKeyId",
                new { Text = this.Text, Description = this.Description, Order = this.Order, AnserKeyId = this.Id }
            );
        }
    }
}
