﻿using System.Data;

namespace WebApplication1.Models;

public class Writer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Book> Books { get; set; }
}
