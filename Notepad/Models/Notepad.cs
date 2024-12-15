using System.ComponentModel.DataAnnotations;

namespace Notepad.Models
{
	public class Notepad
	{
		[Key]
		public int Id { get; set; }
		
		[Required]
		public string? Name { get; set; }

		[Required]
		[DataType(DataType.MultilineText)]
		public string? Description { get; set; }

		[Required]
		public string? Title { get; set; }

		[Required]
		public string? Tags { get; set; }

		[Required]
		public DateTime Created { get; set; }

	}
}
