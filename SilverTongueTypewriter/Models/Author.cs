using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SilverTongueTypewriter.Models
public class Author
{
	public int AuthorId { get; set; }
	[Required]
	public String UserName { get; set; }

	// adding now a child to this
	public List<WrittenWork> WrittenWorks { get; set; }
}