using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SilverTongueTypewriter.Models
public class WrittenWork
{
	public int WrittenWorkId { get; set; }
	[Required]
	public String Title { get; set; }
	public String Description { get; set; }
	public int AuthorId { get; set; }

	//specify that WrittenWork is a reference to parent object Author
	public Author Author { get; set; }
}
