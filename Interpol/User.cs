using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Interpol
{
    class User
    {
        static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb";



        public int getNumberOfRows()
        {

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT COUNT(*) FROM Criminals", conn);
            int count = 0;
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count = Convert.ToInt32(reader[0]);
            }
            reader.Close();
            conn.Close();
            return count;
        }

        public int getFirstCriminalCode()
        {
            int criminalCode = 0;
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_Code FROM Criminals ", conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalCode = Convert.ToInt32(reader[0]);
            } catch (Exception ex) { MessageBox.Show("Отсутсвуют записи в БД"); }
            reader.Close();
            conn.Close();
            return criminalCode;
        }

        public string loadName(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_name FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            string criminalName = "";
            try
            {
                criminalName = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalName;
        }

        public string loadSurname(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_surname FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string criminalSurname = "";
            reader.Read();
            try { 
                criminalSurname = Convert.ToString(reader[0]);
            }
            catch (Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalSurname;
        }

        public string loadSpec(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_spec FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string criminalSpec = "";
            reader.Read();
            try
            {
                criminalSpec = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalSpec;
        }

        public string loadResidence(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_residence FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string criminalResidence = "";
            reader.Read();
            try
            {
                criminalResidence = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalResidence;
        }

        public string loadDate(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_birth_date FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string criminalBirthDate = "";
            reader.Read();
            try
            {
                criminalBirthDate = Convert.ToString(reader[0]);
                criminalBirthDate = criminalBirthDate.Substring(0, criminalBirthDate.Length - 8);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalBirthDate;
        }

        public byte[] imageArray(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_photo FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            byte[] imageBytes = { };
            reader.Read();
            try
            {
                imageBytes = (byte[])reader[0];
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return imageBytes;
        }

        public Image loadPhoto(int criminalCode)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageArray(criminalCode), 0, imageArray(criminalCode).Length);
            Bitmap bmp = new Bitmap(ms);
            return bmp;
        }

        public string loadNickname(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_nickname FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string criminalNickname = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalNickname = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalNickname;
        }

        public string loadCitizenship(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_citizenship FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            string criminalCitizenship = "";
            reader.Read();
            try
            {
                criminalCitizenship = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalCitizenship;
        }

        public string loadBirthplace(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_birthplace FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string criminalBirthplace = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalBirthplace = Convert.ToString(reader[0]);
            }
            catch (Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalBirthplace;
        }

        public string loadEyes(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_eyes FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string criminalEyes = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalEyes = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalEyes;
        }

        public string loadHair(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_hair FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string criminalHair = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalHair = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalHair;
        }

        public string loadHeight(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_height FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string criminalHeight = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalHeight = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalHeight;
        }

        public string loadLanguages(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_languages FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string criminalLanguages = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalLanguages = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalLanguages;
        }

        public string loadGroupName(int criminalCode)
        {
            string criminalGroupName = "Не состоит";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Group_name FROM Groups WHERE Group_code =(SELECT Group_code FROM Criminals WHERE Criminal_code = " + criminalCode + ") ;", conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalGroupName = Convert.ToString(reader[0]);
            }
            catch (Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalGroupName;
        }

        public bool loadGaveUp(int criminalCode)
        {
            bool criminalGaveUp = false;
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_gave_up FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalGaveUp = Convert.ToBoolean(reader[0]);
            }
            catch (Exception ex) { MessageBox.Show("Нет завязавших"); }
            reader.Close();
            conn.Close();
            return criminalGaveUp;
        }

        public bool loadIsDead(int criminalCode)
        {
            bool criminalIsDead = false;
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_is_dead FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                criminalIsDead = Convert.ToBoolean(reader[0]);
            }
            catch (Exception ex) { }
            reader.Close();
            conn.Close();
            return criminalIsDead;
        }

        public string loadDeathDate(int criminalCode)
        {
            string dd = "";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_death_date FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                dd = Convert.ToString(reader[0]);
                dd = dd.Substring(0, dd.Length - 8);
            } catch (Exception ex) { }
            reader.Close();
            conn.Close();
            return dd;
        }

        public string loadDeathPlace(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_death_place FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string dp = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                dp = Convert.ToString(reader[0]);
            }
            catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return dp;
        }

        public string loadDeathCircs(int criminalCode)
        {
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand("SELECT Criminal_death_circs FROM Criminals WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            string dc = "";
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                dc = Convert.ToString(reader[0]);
            }catch(Exception ex) { }
            reader.Close();
            conn.Close();
            return dc;
        }

        public string loadSentences(int criminalCode)
        {
            string sentences = "";

            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand commandSentence = new OleDbCommand("SELECT Sentence_date, Release_date, Notation, Sentence_code, Crime_code FROM Sentence WHERE Criminal_code = " + criminalCode, conn);

            conn.Open();
            OleDbDataReader readerSentence = commandSentence.ExecuteReader();

            while (readerSentence.Read()) {
                try
                {
                    int Crime_code = Convert.ToInt32(readerSentence[4]);
                    OleDbCommand commandCrime = new OleDbCommand("SELECT Crime_type, Crime_description, Crime_term FROM Crimes WHERE Crime_code = " + Crime_code, conn);
                    OleDbDataReader readerCrime = commandCrime.ExecuteReader();
                    readerCrime.Read();
                    sentences += "Преступление: ";
                    sentences = sentences + Convert.ToString(readerCrime[0]);
                    sentences += "\nОписание: ";
                    sentences = sentences + Convert.ToString(readerCrime[1]);
                    sentences += "\nСрок: ";
                    sentences = sentences + Convert.ToString(readerCrime[2]);
                    sentences += "\nДата приговора: ";
                    sentences = sentences + Convert.ToString(readerSentence[0]).Substring(0, Convert.ToString(readerSentence[0]).Length - 8);
                    sentences += "\nДата освобождения: ";
                    sentences = sentences + Convert.ToString(readerSentence[1]).Substring(0, Convert.ToString(readerSentence[1]).Length - 8);
                    sentences += "\nПримечания: ";
                    sentences = sentences + Convert.ToString(readerSentence[2]);
                    sentences += "\n\n";
                    readerCrime.Close();
                }catch(Exception ex) { }
            }
            readerSentence.Close();
            conn.Close();
            return sentences;
        }

        public Criminal[] getAliveCriminals()
        {

            int criminalCode = getFirstCriminalCode();
            Criminal[] criminals = new Criminal[1000000];
            int criminal = 0;
            if (criminalCode == 0) MessageBox.Show("Отсутсвуют данные");
            else {
                do
                {
                    if (loadIsDead(criminalCode) == false)
                    {
                        criminals[criminal] = new Criminal();
                        criminals[criminal].name = loadName(criminalCode);
                        criminals[criminal].surname = loadSurname(criminalCode);
                        criminals[criminal].nickname = loadNickname(criminalCode);
                        criminals[criminal].specialization = loadSpec(criminalCode);
                        criminals[criminal].residence = loadResidence(criminalCode);
                        criminals[criminal].date = loadDate(criminalCode);
                        criminals[criminal].image = loadPhoto(criminalCode);
                        criminals[criminal].code = criminalCode;
                    }
                    criminalCode++;
                    criminal++;
                } while (criminal < getNumberOfRows());
            }
            return criminals;
        }

        public Criminal[] searchResult(string whereCondition)
        {
             Criminal[] criminals = new Criminal[10000];
            int criminal = 0;
            string commText = "SELECT * FROM Criminals WHERE "+ whereCondition+" ;";
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand(commText, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    ms.Write((byte[])reader[16], 0, ((byte[])reader[16]).Length);
                    criminals[criminal] = new Criminal
                    {
                        name = reader[1].ToString(),
                        surname = reader[2].ToString(),
                        nickname = reader[3].ToString(),
                        specialization = reader[15].ToString(),
                        residence = reader[10].ToString(),
                        date = reader[4].ToString().Substring(0, reader[4].ToString().Length - 8),
                        image = new Bitmap(ms),
                        code = Convert.ToInt32(reader[0])
                    };
                }
                catch(Exception ex) { Console.WriteLine("Ошибка при выполнении поиска."); }
            }
            return criminals;
        }

        public Group[] getGroups()
        {
            byte group = 0;
            Group[] groups = new Group[127];
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand commandGroups = new OleDbCommand("SELECT Group_code, Group_name, Group_leader, Group_info, Group_activity_years FROM Groups ;", conn);
            conn.Open();
            OleDbDataReader readerGroups = commandGroups.ExecuteReader();
            while (readerGroups.Read())
            {
                groups[group] = new Group();
                groups[group].GroupCode = Convert.ToInt32(readerGroups[0]);
                groups[group].GroupName = Convert.ToString(readerGroups[1]);
                groups[group].GroupLeader = Convert.ToString(readerGroups[2]);
                groups[group].GroupInfo = Convert.ToString(readerGroups[3]);
                groups[group].GroupActYears = Convert.ToString(readerGroups[4]);
                groups[group].loadLinks(Convert.ToInt32(readerGroups[0]));
                group++;
            }
            readerGroups.Close();
            conn.Close();
            return groups;
        }

        public Criminal[] getDeadCriminals()
        {
            int criminalCode = getFirstCriminalCode();
            Criminal[] criminals = new Criminal[1000000];
            int criminal = 0;
            do
            {
                if (loadIsDead(criminalCode) == true)
                {
                    criminals[criminal] = new Criminal
                    {
                        name = loadName(criminalCode),
                        surname = loadSurname(criminalCode),
                        nickname = loadNickname(criminalCode),
                        specialization = loadSpec(criminalCode),
                        residence = loadResidence(criminalCode),
                        date = loadDate(criminalCode),
                        image = loadPhoto(criminalCode),
                        code = criminalCode
                    };
                }
                criminal++;
                criminalCode++;
            } while (criminal < getNumberOfRows());
            return criminals;
        }

        public Criminal[] getGaveUpCriminals()
        {
            int criminalCode = getFirstCriminalCode();
            Criminal[] criminals = new Criminal[1000000];
            int criminal = 0;
            do
            {
                if (loadGaveUp(criminalCode) == true)
                {
                    criminals[criminal] = new Criminal
                    {
                        name = loadName(criminalCode),
                        surname = loadSurname(criminalCode),
                        nickname = loadNickname(criminalCode),
                        specialization = loadSpec(criminalCode),
                        residence = loadResidence(criminalCode),
                        date = loadDate(criminalCode),
                        image = loadPhoto(criminalCode),
                        code = criminalCode
                    };
                }
                criminal++;
                criminalCode++;
            } while (criminal < getNumberOfRows());
            return criminals;
        }
    }
}
