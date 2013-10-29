﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BooksManagement.classes;
using MySql.Data.MySqlClient;

namespace BooksManagement.DBOpreation
{
    public class DBInteraction
    {
        #region Category Operation
        /// <summary>
        /// add a category then return the id
        /// </summary>
        /// <param name="category"></param>
        /// <returns>category id</returns>
        static public bool AddCategory(Category category)
        {
            string sql = "insert into category (id, categoryname) values (?id, ?category);";
            MySqlParameter[] mysqlParameter =
                {
                    new MySqlParameter("?id", category.Id),
                    new MySqlParameter("?category", category.CategoryName)
                };
            int result;
            try
            {
                result = MySqlHelper.ExecuteNonQuery(CommandType.Text, sql, mysqlParameter);
            }
            catch (Exception ex)
            {

                return false;
            }
            return result > 0;
        }

        static public bool DeleteCategory(Category category)
        {
            string sql = "delete from category where id = ?id";
            MySqlParameter[] mysqlParameters = { new MySqlParameter("?id", category.Id) };
            int result;
            try
            {
                result = MySqlHelper.ExecuteNonQuery(CommandType.Text, sql, mysqlParameters);
            }
            catch (Exception ex)
            {
                return false;
            }
            return result > 0;
        }

        static public bool GetCategory(Category category)
        {
            string sql = "select id from category where categoryname = ?categoryname";
            MySqlParameter[] parameters = { new MySqlParameter("?categoryname", category.CategoryName) };
            object result;
            try
            {
                result = MySqlHelper.ExecuteScalar(CommandType.Text, sql, parameters);
            }
            catch (Exception ex)
            {
                return false;
            }
            category.Id = result as string ?? string.Empty;

            return GetBooksbyCategoryId(category);
        }

        static public bool ChangeCategory(Category category)
        {
            string sql = "update category set categoryname = ?categoryname where id = ?id";
            MySqlParameter[] parameters =
                {
                    new MySqlParameter("?categoryname", category.CategoryName),
                    new MySqlParameter("?id", category.Id)
                };
            int result;
            try
            {
                result = MySqlHelper.ExecuteNonQuery(CommandType.Text, sql, parameters);
            }
            catch (Exception ex)
            {
                return false;
            }
            return result > 0;
        }

        #endregion

        #region Books Operation

        static public bool GetBooksbyCategoryId(Category catagory)
        {
            string sql =
                "select id, categoryid, bookname, location, picture, uri, readtimes from book where categoryid = ?categoryid;";
            MySqlParameter[] parameters = { new MySqlParameter("?categoryid", catagory.Id) };
            try
            {
                MySqlDataReader msdr = MySqlHelper.ExecuteReader(CommandType.Text, sql, parameters);
                while (msdr.Read())
                {
                    Book book = new Book();
                    book.Id = msdr["id"].ToString();
                    book.CategoryId = catagory.Id;
                    book.BookName = msdr["bookname"].ToString();
                    book.Location = msdr["location"].ToString();
                    book.Picutre = msdr["picture"].ToString();
                    book.URI = msdr["uri"].ToString();
                    book.ReadTimes = (int) msdr["readtimes"];
                    catagory.Books.Add(book);
                }
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        static public DataTable FindBooksByName(string bookName)
        {
            string sql = "select a.id id, a.bookname bookname, b.CategoryName CategoryName, c.author author, c.translator translator, c.words words, " +
                            "c.publisher publisher, c.publishdate publishdate, c.ISBN ISBN, c.label label " +
                            "from book a, category b, bookdetail c " +
                            "where a.categoryid = b.ID and a.id = c.bookid and a.bookname = ?name;";

            MySqlParameter[] parameter = 
                {
                    new MySqlParameter("?name", bookName)
                };
            try
            {
                return MySqlHelper.GetDataSet(CommandType.Text, sql, parameter).Tables[0];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// insert the book object, after success return the book with bookid.
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        static public bool AddOneBook(Book book)
        {
            string sql = "insert into book (id, categoryid, bookname, location, picture, uri, readtimes)"
                + " values (?id, ?categoryid, ?bookname, ?location, ?picture, ?uri, ?readtimes)";
            MySqlParameter[] parameters =
                {
                    new MySqlParameter("?id",book.Id),
                    new MySqlParameter("?categoryid",book.CategoryId),
                    new MySqlParameter("?bookname",book.BookName),
                    new MySqlParameter("?location",book.Location),
                    new MySqlParameter("?picture",book.Picutre),
                    new MySqlParameter("?uri",book.URI),
                    new MySqlParameter("?readtimes",book.ReadTimes)
                };
            int result;
            try
            {
                result = MySqlHelper.ExecuteNonQuery(CommandType.Text, sql, parameters);
            }
            catch (Exception ex)
            {
                return false;
            }
            return result > 0;
        }

        /// <summary>
        /// test method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        static public bool UpdateBookName(string name, string id)
        {
            string sql = "update book set bookname = ?name where id = ?id;";

            MySqlParameter[] parameter = 
                {
                    new MySqlParameter("?name", name),
                    new MySqlParameter("?id", id)
                };
            int a;
            try
            {
                a = MySqlHelper.ExecuteNonQuery(CommandType.Text, sql, parameter);
            }
            catch (Exception ex)
            {
                return false;
            }
            return a > 0;
        }

        #endregion

        #region Settings Operation

        static public string GetBookRepository()
        {
            string sql = "select settingvalue from settings where settingkey = 'baselocation';";
            object repositoryPath = null;
            try
            {
                repositoryPath = MySqlHelper.ExecuteScalar(CommandType.Text, sql, null);
            }
            catch (Exception ex)
            {

                return string.Empty;
            }
            return repositoryPath as string;
        }

        #endregion

    }
}