using System;
using EstimateBuilder;
using System.Text;
using System.Data;

namespace EstimateBuilder
{
	/// <summary>
	/// Summary description for ContactDataProvider.
	/// </summary>
	public class ContactDataProvider
	{
		public ContactDataProvider()
		{
		}
		
		public void add(EstimateBuilder.ContactData _contact)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append(" INSERT INTO Contact (Division_Contact,");
			strSQL.Append("DivisionCost_Contact, Contract, OutlookID,");
            strSQL.Append("Company, FirstName, LastName, MiddleName, Title,");
            strSQL.Append("Address, City, State, ZipCode, Region,");
			strSQL.Append("PhoneVoice, PhoneExtension, PhoneCell,");
			strSQL.Append("PhoneFax, Email, RecordID, [Memo] ) VALUES (");			
			strSQL.Append("'"+ _contact.Division + "', ");
			strSQL.Append("'"+ _contact.DivisionCost +"', ");
			strSQL.Append(_contact.Contract +", ");
			strSQL.Append(_contact.OutlookID +", ");
			strSQL.Append("'"+_contact.Company +"', ");
			strSQL.Append("'"+_contact.FirstName +"', ");
			strSQL.Append("'"+_contact.LastName +"', ");
            strSQL.Append("'" + _contact.MiddleName + "', ");
            strSQL.Append("'"+_contact.Title +"', ");
			strSQL.Append("'"+_contact.Address +"', ");
			strSQL.Append("'"+_contact.City +"', ");
			strSQL.Append("'"+_contact.State +"', ");
			strSQL.Append("'"+_contact.ZipCode +"', ");
			strSQL.Append("'"+_contact.Region +"', ");
			strSQL.Append("'"+_contact.PhoneVoice +"', ");
			strSQL.Append("'"+_contact.PhoneExtension +"', ");
			strSQL.Append("'"+_contact.PhoneCell +"', ");
			strSQL.Append("'"+_contact.PhoneFax +"', ");
			strSQL.Append("'"+_contact.Email +"', ");
			strSQL.Append(_contact.RecordID +", ");
			strSQL.Append("'"+_contact.Memo +"')");
			try
			{
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch{}
		}

        public void Copy(EstimateBuilder.ContactData _contact)
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append(" INSERT INTO Contact (Division_Contact,");
            strSQL.Append("DivisionCost_Contact, Contract, OutlookID,");
            strSQL.Append("Company, FirstName, LastName, MiddleName, Title,");
            strSQL.Append("Address, City, State, ZipCode, Region,");
            strSQL.Append("PhoneVoice, PhoneExtension, PhoneCell,");
            strSQL.Append("PhoneFax, Email, RecordID, [Memo] ) VALUES (");
            strSQL.Append("'" + _contact.Division + "', ");
            strSQL.Append("'" + _contact.DivisionCost + "', ");
            strSQL.Append(_contact.Contract + ", ");
            strSQL.Append(_contact.OutlookID + ", ");
            strSQL.Append("' Copy " + _contact.Company + "', ");
            strSQL.Append("'" + _contact.FirstName + "', ");
            strSQL.Append("'" + _contact.LastName + "', ");
            strSQL.Append("'" + _contact.MiddleName + "', ");
            strSQL.Append("'" + _contact.Title + "', ");
            strSQL.Append("'" + _contact.Address + "', ");
            strSQL.Append("'" + _contact.City + "', ");
            strSQL.Append("'" + _contact.State + "', ");
            strSQL.Append("'" + _contact.ZipCode + "', ");
            strSQL.Append("'" + _contact.Region + "', ");
            strSQL.Append("'" + _contact.PhoneVoice + "', ");
            strSQL.Append("'" + _contact.PhoneExtension + "', ");
            strSQL.Append("'" + _contact.PhoneCell + "', ");
            strSQL.Append("'" + _contact.PhoneFax + "', ");
            strSQL.Append("'" + _contact.Email + "', ");
            strSQL.Append(_contact.RecordID + ", ");
            strSQL.Append("' Copy " + _contact.Memo + "')");
            try
            {
                _data.ExecuteSQL(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            }
            catch { }
        }



		public void update(EstimateBuilder.ContactData _contact)
		{		
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append("UPDATE Contact SET ");
			strSQL.Append("Division_Contact = '"+ _contact.Division + "',");
            strSQL.Append("[DivisionCost_Contact] = '" + _contact.DivisionCost + "',");
            strSQL.Append("Contract = "+ _contact.Contract + ",");
			strSQL.Append("OutlookID = "+ _contact.OutlookID + ",");
			strSQL.Append("Company = '"+ _contact.Company + "',"); 
			strSQL.Append("FirstName = '"+ _contact.FirstName + "',");
            strSQL.Append("MiddleName = '" + _contact.MiddleName + "',");

            strSQL.Append("LastName = '"+ _contact.LastName + "',"); 
			strSQL.Append("Title = '"+ _contact.Title + "',");
			strSQL.Append("Address = '"+ _contact.Address + "',"); 
			strSQL.Append("City = '"+ _contact.City + "',");
			strSQL.Append("State = '"+ _contact.State + "',");
			strSQL.Append("ZipCode = '"+ _contact.ZipCode + "',"); 
			strSQL.Append("Region = '"+ _contact.Region + "',");
			strSQL.Append("PhoneVoice = '"+ _contact.PhoneVoice + "',"); 
			strSQL.Append("PhoneExtension = '"+ _contact.PhoneExtension + "',");
			strSQL.Append("PhoneCell = '"+ _contact.PhoneCell + "',"); 
			strSQL.Append("PhoneFax = '"+ _contact.PhoneFax + "',"); 
			strSQL.Append("Email = '"+ _contact.Email + "',"); 
			strSQL.Append("RecordID ="+ _contact.RecordID + ",");
			strSQL.Append("[Memo] = '"+ _contact.Memo + "'");
			strSQL.Append(" WHERE ContactID ="+ _contact.ContactID );

			try
			{
				_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);
			}
			catch
			{

			}
		}

		#region tested
		public void delete(EstimateBuilder.ContactData _contact)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();
			strSQL.Append(" DELETE * FROM Contact WHERE ContactID ="+ _contact.ContactID);

			_data.ExecuteSQL(strSQL.ToString(),EstimateBuilder.ApplicationBuilder.connection);


		}

       public  DataSet selectData(string _id)
		{
			StringBuilder strSQL = new StringBuilder();
			EstimateBuilder.stData  _data = new EstimateBuilder.stData();

			strSQL.Append("SELECT ContactID, Division_Contact, DivisionCost_Contact, Contract, OutlookID, Company, ");
            strSQL.Append(" FirstName, LastName, MiddleName,Title,Address, City, State, ZipCode, Region, ");
            strSQL.Append(" PhoneVoice, PhoneExtension, PhoneCell, PhoneFax, Email, ");
			strSQL.Append(" RecordID, Memo ");
            strSQL.Append(" FROM Contact WHERE Division_Contact ='" + _id + "'");

             try
            {
                DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
                return dsData;
             }
              catch
             {
                return null;
              }
            }


		public  EstimateBuilder.ContactDatas select(string _id)
		{
            DataSet dsData = selectData(_id);

            EstimateBuilder.ContactDatas _contactDatas = new EstimateBuilder.ContactDatas();
                int i = 0;
                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    EstimateBuilder.ContactData _contactData = new EstimateBuilder.ContactData();

                    i += 1;
                    _contactData.NumbID = i;

                    _contactData.Address = row["Address"].ToString();
                    _contactData.City = row["City"].ToString();
                    _contactData.Company = row["Company"].ToString();
                    _contactData.Contract = row["Contract"].ToString();
                    _contactData.Division = row["Division_Contact"].ToString();
                    _contactData.DivisionCost = row["DivisionCost_Contact"].ToString();
                    _contactData.Email = row["Email"].ToString();
                    _contactData.FirstName = row["FirstName"].ToString();
                    _contactData.LastName = row["LastName"].ToString();
                    _contactData.MiddleName = row["MiddleName"].ToString();
                    _contactData.Memo = row["Memo"].ToString();
                    _contactData.PhoneCell = row["PhoneCell"].ToString();
                    _contactData.PhoneExtension = row["PhoneExtension"].ToString();
                    _contactData.PhoneFax = row["PhoneFax"].ToString();
                    _contactData.PhoneVoice = row["PhoneVoice"].ToString();
                    try
                    {
                        _contactData.RecordID = Convert.ToInt32(row["RecordID"].ToString());
                    }
                    catch
                    {
                        _contactData.RecordID = 0;
                    }
                    try
                    {
                        _contactData.OutlookID = Convert.ToInt32(row["OutlookID"].ToString());
                    }
                    catch
                    {
                        _contactData.OutlookID = 0;
                    }
                    try
                    {
                        _contactData.ContactID = Convert.ToInt32(row["ContactID"].ToString());
                    }
                    catch
                    {
                        _contactData.ContactID = 0;
                    }
                    _contactData.Region = row["Region"].ToString();
                    _contactData.State = row["State"].ToString();
                    _contactData.Title = row["Title"].ToString();
                    _contactData.ZipCode = row["ZipCode"].ToString();

                    _contactDatas.Add(_contactData);
                }
                return _contactDatas;
            
        }

        public DataSet selectData()
        {
            StringBuilder strSQL = new StringBuilder();
            EstimateBuilder.stData _data = new EstimateBuilder.stData();

            strSQL.Append("SELECT ContactID, Division_Contact, DivisionCost_Contact, Contract, OutlookID, Company, ");
            strSQL.Append(" FirstName, LastName, MiddleName,Title,Address, City, State, ZipCode, Region, ");
            strSQL.Append(" PhoneVoice, PhoneExtension, PhoneCell, PhoneFax, Email, ");
            strSQL.Append(" RecordID, Memo");
            strSQL.Append(" FROM Contact ");

            DataSet dsData = _data.getDataSet(strSQL.ToString(), EstimateBuilder.ApplicationBuilder.connection);
            return dsData;
        }

        public EstimateBuilder.ContactDatas select()
		{
            DataSet dsData = selectData();

            EstimateBuilder.ContactDatas _contactDatas = new EstimateBuilder.ContactDatas();
                int i = 0;
                foreach (DataRow row in dsData.Tables[0].Rows)
                {
                    EstimateBuilder.ContactData _contactData = new EstimateBuilder.ContactData();

                    i += 1;
                    _contactData.NumbID = i;
                    _contactData.Address = row["Address"].ToString();
                    _contactData.City = row["City"].ToString();
                    _contactData.Company = row["Company"].ToString();
                    _contactData.Contract = row["Contract"].ToString();
                    _contactData.Division = row["Division_Contact"].ToString();
                    _contactData.DivisionCost = row["DivisionCost_Contact"].ToString();
                    _contactData.Email = row["Email"].ToString();
                    _contactData.FirstName = row["FirstName"].ToString();
                    _contactData.LastName = row["LastName"].ToString();
                    _contactData.MiddleName = row["MiddleName"].ToString();
                    _contactData.Memo = row["Memo"].ToString();
                    _contactData.PhoneCell = row["PhoneCell"].ToString();
                    _contactData.PhoneExtension = row["PhoneExtension"].ToString();
                    _contactData.PhoneFax = row["PhoneFax"].ToString();
                    _contactData.PhoneVoice = row["PhoneVoice"].ToString();
                    try
                    {
                        _contactData.RecordID = Convert.ToInt32(row["RecordID"].ToString());
                    }
                    catch
                    {
                        _contactData.RecordID = 0;
                    }
                    try
                    {
                        _contactData.OutlookID = Convert.ToInt32(row["OutlookID"].ToString());
                    }
                    catch
                    {
                        _contactData.OutlookID = 0;
                    }
                    try
                    {
                        _contactData.ContactID = Convert.ToInt32(row["ContactID"].ToString());
                    }
                    catch
                    {
                        _contactData.ContactID = 0;
                    }
                    _contactData.Region = row["Region"].ToString();
                    _contactData.State = row["State"].ToString();
                    _contactData.Title = row["Title"].ToString();
                    _contactData.ZipCode = row["ZipCode"].ToString();

                    _contactDatas.Add(_contactData);
                }
                return _contactDatas;
            
        }

		public void Dispose()
		{
			GC.Collect();
		}

		#endregion




	}
}
