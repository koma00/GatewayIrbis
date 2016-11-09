using System;
using System.Linq;

using ManagedClient;
using System.Collections.Generic;
using WpfTestApplication;
using System.Net;
using Npgsql;
using System.Data.Common;

namespace MainClass
{
    class Program
    {
        /*static DbDataRecord Select(NpgsqlConnection npgSqlConnection, string number)
        {
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM users WHERE number = @number", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            if (npgSqlDataReader.HasRows)
            {
                Console.WriteLine("Таблица: books");
                Console.WriteLine("id     name      author");
                foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
                    return dbDataRecord;
                    //Console.WriteLine(dbDataRecord["id"] + "   " + dbDataRecord["name"] + "   " + dbDataRecord["author"]);
            }
            else
            {
                Console.WriteLine("Запрос не вернул строк");
            }
            return null;
        }*/
        static bool Insert(NpgsqlConnection npgSqlConnection, IrbisRecord record)
        {
            //main

            NpgsqlCommand npgSqlCommandMain = new NpgsqlCommand("INSERT INTO main(surname, name, middle_name, date_birth, id_reader, library_card_number, gender, citizenship, number_student_card, passport_data, home_phone, registered_to, job, post, education, note, right_to_use, reader_photos, name_worksheet) VALUES (@surname, @name, @middle_name, @date_birth, @id_reader, @library_card_number, @gender, @citizenship, @number_student_card, @passport_data, @home_phone, @registered_to, @job, @post, @education, @note, @right_to_use, @reader_photos, @name_worksheet) returning id", npgSqlConnection);

            string surname = record.FM("10");
            string name = record.FM("11");
            string middle_name = record.FM("12");
            string date_birth = record.FM("21");
            string id_reader = record.FM("30");
            string library_card_number = record.FM("24");
            string gender = record.FM("23");
            string citizenship = record.FM("25");
            string number_student_card = record.FM("22");
            string passport_data = record.FM("14");
            string home_phone = record.FM("17");
            string registered_to = record.FM("34");
            string job = record.FM("15");
            string post = record.FM("16");
            string education = record.FM("20");
            string note = record.FM("33");
            string right_to_use = record.FM("29");
            string reader_photos = record.FM("950");
            string name_worksheet = record.FM("920");

            NpgsqlParameter npgSqlParameterSurname = new NpgsqlParameter("@surname", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterName = new NpgsqlParameter("@name", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterMiddle_name = new NpgsqlParameter("@middle_name", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterDate_birth = new NpgsqlParameter("@date_birth", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterID_reader = new NpgsqlParameter("@id_reader", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterLibrary_card_number = new NpgsqlParameter("@library_card_number", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterGender = new NpgsqlParameter("@gender", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterCitizenship = new NpgsqlParameter("@citizenship", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterNumber_student_card = new NpgsqlParameter("@number_student_card", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterPassport_data = new NpgsqlParameter("@passport_data", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterHome_phone = new NpgsqlParameter("@home_phone", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterRegistered_to = new NpgsqlParameter("@registered_to", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterJob = new NpgsqlParameter("@job", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterPost = new NpgsqlParameter("@post", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterEducation = new NpgsqlParameter("@education", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterNote = new NpgsqlParameter("@note", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterRight_to_use = new NpgsqlParameter("@right_to_use", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterReader_photos = new NpgsqlParameter("@reader_photos", NpgsqlTypes.NpgsqlDbType.Varchar);
            NpgsqlParameter npgSqlParameterName_worksheet = new NpgsqlParameter("@name_worksheet", NpgsqlTypes.NpgsqlDbType.Varchar);

            npgSqlParameterSurname.Value = surname;
            npgSqlParameterName.Value = name;
            npgSqlParameterMiddle_name.Value = middle_name;
            npgSqlParameterDate_birth.Value = date_birth;
            npgSqlParameterID_reader.Value = id_reader;
            npgSqlParameterLibrary_card_number.Value = library_card_number;
            npgSqlParameterGender.Value = gender;
            npgSqlParameterCitizenship.Value = citizenship;
            npgSqlParameterNumber_student_card.Value = number_student_card;
            npgSqlParameterPassport_data.Value = passport_data;
            npgSqlParameterHome_phone.Value = home_phone;
            npgSqlParameterRegistered_to.Value = registered_to;
            npgSqlParameterJob.Value = job;
            npgSqlParameterPost.Value = post;
            npgSqlParameterEducation.Value = education;
            npgSqlParameterNote.Value = note;
            npgSqlParameterRight_to_use.Value = right_to_use;
            npgSqlParameterReader_photos.Value = reader_photos;
            npgSqlParameterName_worksheet.Value = name_worksheet;

            npgSqlCommandMain.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterSurname, npgSqlParameterName, npgSqlParameterMiddle_name, npgSqlParameterDate_birth, npgSqlParameterID_reader, npgSqlParameterLibrary_card_number, npgSqlParameterGender, npgSqlParameterCitizenship, npgSqlParameterNumber_student_card, npgSqlParameterPassport_data, npgSqlParameterHome_phone, npgSqlParameterRegistered_to, npgSqlParameterJob, npgSqlParameterPost, npgSqlParameterEducation, npgSqlParameterNote, npgSqlParameterRight_to_use, npgSqlParameterReader_photos, npgSqlParameterName_worksheet });
            NpgsqlDataReader reader = npgSqlCommandMain.ExecuteReader();

            int id = 0;

            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            //previous_full_name

            RecordField[] previous_full_name_records = record.Fields.GetField("27").ToArray();
            foreach (var previous_full_name_record in previous_full_name_records)
            {
                NpgsqlCommand npgSqlCommandPrevious_full_name = new NpgsqlCommand("INSERT INTO previous_full_name(id, full_name) VALUES (@id, @full_name)", npgSqlConnection);

                string full_name = previous_full_name_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterFull_name = new NpgsqlParameter("@full_name", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterFull_name.Value = full_name;

                npgSqlCommandPrevious_full_name.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterFull_name });
                int count = npgSqlCommandPrevious_full_name.ExecuteNonQuery();
            }

            //category

            RecordField[] category_records = record.Fields.GetField("50").ToArray();
            foreach (var category_record in category_records)
            {
                NpgsqlCommand npgSqlCommandCategory = new NpgsqlCommand("INSERT INTO category(id, category) VALUES (@id, @category)", npgSqlConnection);

                string category = category_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterCategory = new NpgsqlParameter("@category", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterCategory.Value = category;

                npgSqlCommandCategory.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterCategory });
                int count = npgSqlCommandCategory.ExecuteNonQuery();
            }

            //foreign_language

            RecordField[] foreign_language_records = record.Fields.GetField("26").ToArray();
            foreach (var foreign_language_record in foreign_language_records)
            {
                NpgsqlCommand npgSqlCommandForeign_language = new NpgsqlCommand("INSERT INTO foreign_language(id, foreign_language) VALUES (@id, @foreign_language)", npgSqlConnection);

                string foreign_language = foreign_language_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterForeign_language = new NpgsqlParameter("@foreign_language", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterForeign_language.Value = foreign_language;

                npgSqlCommandForeign_language.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterForeign_language });
                int count = npgSqlCommandForeign_language.ExecuteNonQuery();
            }

            //date_admission

            RecordField[] date_admission_records = record.Fields.GetField("53").ToArray();
            foreach (var date_admission_record in date_admission_records)
            {
                NpgsqlCommand npgSqlCommandDate_admission = new NpgsqlCommand("INSERT INTO date_admission(id, date, place_registration, order_number, cause) VALUES (@id, @date, @place_registration, @order_number, @cause)", npgSqlConnection);

                string date = date_admission_record.GetFieldText();
                string place_registration = date_admission_record.GetSubFieldText('C', 0);
                string order_number = date_admission_record.GetSubFieldText('A', 0);
                string cause = date_admission_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDate = new NpgsqlParameter("@date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPlace_registration = new NpgsqlParameter("@place_registration", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterOrder_number = new NpgsqlParameter("@order_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCause = new NpgsqlParameter("@cause", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDate.Value = date;
                npgSqlParameterPlace_registration.Value = place_registration;
                npgSqlParameterOrder_number.Value = order_number;
                npgSqlParameterCause.Value = cause;

                npgSqlCommandDate_admission.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDate, npgSqlParameterPlace_registration, npgSqlParameterOrder_number, npgSqlParameterCause });
                int count = npgSqlCommandDate_admission.ExecuteNonQuery();
            }

            //date_deduction

            RecordField[] date_deduction_records = record.Fields.GetField("54").ToArray();
            foreach (var date_deduction_record in date_deduction_records)
            {
                NpgsqlCommand npgSqlCommandDate_deduction = new NpgsqlCommand("INSERT INTO date_deduction(id, date, order_number, cause, restored, faculty, specialty) VALUES (@id, @date, @order_number, @cause, @restored, @faculty, @specialty)", npgSqlConnection);

                string date = date_deduction_record.GetFieldText();
                string order_number = date_deduction_record.GetSubFieldText('A', 0);
                string cause = date_deduction_record.GetSubFieldText('B', 0);
                string restored = date_deduction_record.GetSubFieldText('C', 0);
                string faculty = date_deduction_record.GetSubFieldText('F', 0);
                string specialty = date_deduction_record.GetSubFieldText('S', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDate = new NpgsqlParameter("@date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterOrder_number = new NpgsqlParameter("@order_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCause = new NpgsqlParameter("@cause", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterRestored = new NpgsqlParameter("@restored", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterFaculty = new NpgsqlParameter("@faculty", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterSpecialty = new NpgsqlParameter("@specialty", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDate.Value = date;
                npgSqlParameterOrder_number.Value = order_number;
                npgSqlParameterCause.Value = cause;
                npgSqlParameterRestored.Value = restored;
                npgSqlParameterFaculty.Value = faculty;
                npgSqlParameterSpecialty.Value = specialty;

                npgSqlCommandDate_deduction.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDate, npgSqlParameterOrder_number, npgSqlParameterCause, npgSqlParameterRestored, npgSqlParameterFaculty, npgSqlParameterSpecialty });
                int count = npgSqlCommandDate_deduction.ExecuteNonQuery();
            }

            //home_address

            RecordField[] home_address_records = record.Fields.GetField("13").ToArray();
            foreach (var home_address_record in home_address_records)
            {
                NpgsqlCommand npgSqlCommandHome_address = new NpgsqlCommand("INSERT INTO home_address(id, postcode, republic, city, street, house_number, entrance_number, apartment_number, additional_information) VALUES (@id, @postcode, @republic, @city, @street, @house_number, @entrance_number, @apartment_number, @additional_information)", npgSqlConnection);

                string postcode = home_address_record.GetSubFieldText('A', 0);
                string republic = home_address_record.GetSubFieldText('B', 0);
                string city = home_address_record.GetSubFieldText('C', 0);
                string street = home_address_record.GetSubFieldText('D', 0);
                string house_number = home_address_record.GetSubFieldText('E', 0);
                string entrance_number = home_address_record.GetSubFieldText('G', 0);
                string apartment_number = home_address_record.GetSubFieldText('H', 0);
                string additional_information = home_address_record.GetSubFieldText('F', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterPostcode = new NpgsqlParameter("@postcode", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterRepublic = new NpgsqlParameter("@republic", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCity = new NpgsqlParameter("@city", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterStreet = new NpgsqlParameter("@street", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterHouse_number = new NpgsqlParameter("@house_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterEntrance_number = new NpgsqlParameter("@entrance_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterApartment_number = new NpgsqlParameter("@apartment_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterAdditional_information = new NpgsqlParameter("@additional_information", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterPostcode.Value = postcode;
                npgSqlParameterRepublic.Value = republic;
                npgSqlParameterCity.Value = city;
                npgSqlParameterStreet.Value = street;
                npgSqlParameterHouse_number.Value = house_number;
                npgSqlParameterEntrance_number.Value = entrance_number;
                npgSqlParameterApartment_number.Value = apartment_number;
                npgSqlParameterAdditional_information.Value = additional_information;
                npgSqlCommandHome_address.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterPostcode, npgSqlParameterRepublic, npgSqlParameterCity, npgSqlParameterStreet, npgSqlParameterHouse_number, npgSqlParameterEntrance_number, npgSqlParameterApartment_number, npgSqlParameterAdditional_information });
                int count = npgSqlCommandHome_address.ExecuteNonQuery();
            }

            //business_phone

            RecordField[] business_phone_records = record.Fields.GetField("18").ToArray();
            foreach (var business_phone_record in business_phone_records)
            {
                NpgsqlCommand npgSqlCommandBusiness_phone = new NpgsqlCommand("INSERT INTO business_phone(id, business_phone) VALUES (@id, @business_phone)", npgSqlConnection);

                string business_phone = business_phone_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterBusiness_phone = new NpgsqlParameter("@business_phone", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterBusiness_phone.Value = business_phone;

                npgSqlCommandBusiness_phone.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterBusiness_phone });
                int count = npgSqlCommandBusiness_phone.ExecuteNonQuery();
            }

            //email

            RecordField[] email_records = record.Fields.GetField("32").ToArray();
            foreach (var email_record in email_records)
            {
                NpgsqlCommand npgSqlCommandEmail = new NpgsqlCommand("INSERT INTO email(id, email) VALUES (@id, @email)", npgSqlConnection);

                string email = email_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterEmail = new NpgsqlParameter("@email", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterEmail.Value = email;

                npgSqlCommandEmail.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterEmail });
                int count = npgSqlCommandEmail.ExecuteNonQuery();
            }

            //academic_degree

            RecordField[] academic_degree_records = record.Fields.GetField("28").ToArray();
            foreach (var academic_degree_record in academic_degree_records)
            {
                NpgsqlCommand npgSqlCommandAcademic_degree = new NpgsqlCommand("INSERT INTO academic_degree(id, academic_degree, academic_title) VALUES (@id, @academic_degree, @academic_title)", npgSqlConnection);

                string academic_degree = academic_degree_record.GetSubFieldText('A', 0);
                string academic_title = academic_degree_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterAcademic_degree = new NpgsqlParameter("@academic_degree", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterAcademic_title = new NpgsqlParameter("@academic_title", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterAcademic_degree.Value = academic_degree;
                npgSqlParameterAcademic_title.Value = academic_title;

                npgSqlCommandAcademic_degree.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterAcademic_degree, npgSqlParameterAcademic_title });
                int count = npgSqlCommandAcademic_degree.ExecuteNonQuery();
            }

            //record_date

            RecordField[] record_date_records = record.Fields.GetField("51").ToArray();
            foreach (var record_date_record in record_date_records)
            {
                NpgsqlCommand npgSqlCommandRecord_date = new NpgsqlCommand("INSERT INTO record_date(id, date, place_registration, order_number, cause) VALUES (@id, @date, @place_registration, @order_number, @cause)", npgSqlConnection);

                string date = record_date_record.GetFieldText();
                string place_registration = record_date_record.GetSubFieldText('C', 0);
                string order_number = record_date_record.GetSubFieldText('A', 0);
                string cause = record_date_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDate = new NpgsqlParameter("@date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPlace_registration = new NpgsqlParameter("@place_registration", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterOrder_number = new NpgsqlParameter("@order_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCause = new NpgsqlParameter("@cause", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDate.Value = date;
                npgSqlParameterPlace_registration.Value = place_registration;
                npgSqlParameterOrder_number.Value = order_number;
                npgSqlParameterCause.Value = cause;

                npgSqlCommandRecord_date.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDate, npgSqlParameterPlace_registration, npgSqlParameterOrder_number, npgSqlParameterCause });
                int count = npgSqlCommandRecord_date.ExecuteNonQuery();
            }

            //re_registration_date

            RecordField[] re_registration_date_records = record.Fields.GetField("52").ToArray();
            foreach (var re_registration_date_record in re_registration_date_records)
            {
                NpgsqlCommand npgSqlCommandRe_registration_date = new NpgsqlCommand("INSERT INTO re_registration_date(id, date, place_registration, order_number, cause) VALUES (@id, @date, @place_registration, @order_number, @cause)", npgSqlConnection);

                string date = re_registration_date_record.GetFieldText();
                string place_registration = re_registration_date_record.GetSubFieldText('C', 0);
                string order_number = re_registration_date_record.GetSubFieldText('A', 0);
                string cause = re_registration_date_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDate = new NpgsqlParameter("@date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPlace_registration = new NpgsqlParameter("@place_registration", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterOrder_number = new NpgsqlParameter("@order_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCause = new NpgsqlParameter("@cause", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDate.Value = date;
                npgSqlParameterPlace_registration.Value = place_registration;
                npgSqlParameterOrder_number.Value = order_number;
                npgSqlParameterCause.Value = cause;

                npgSqlCommandRe_registration_date.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDate, npgSqlParameterPlace_registration, npgSqlParameterOrder_number, npgSqlParameterCause });
                int count = npgSqlCommandRe_registration_date.ExecuteNonQuery();
            }

            //authorized_places

            RecordField[] authorized_places_records = record.Fields.GetField("56").ToArray();
            foreach (var authorized_places_record in authorized_places_records)
            {
                NpgsqlCommand npgSqlCommandAuthorized_places = new NpgsqlCommand("INSERT INTO authorized_places(id, authorized_places) VALUES (@id, @authorized_places)", npgSqlConnection);

                string authorized_places = authorized_places_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterAuthorized_places = new NpgsqlParameter("@authorized_places", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterAuthorized_places.Value = authorized_places;

                npgSqlCommandAuthorized_places.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterAuthorized_places });
                int count = npgSqlCommandAuthorized_places.ExecuteNonQuery();
            }

            //unauthorized_places

            RecordField[] unauthorized_places_records = record.Fields.GetField("57").ToArray();
            foreach (var unauthorized_places_record in unauthorized_places_records)
            {
                NpgsqlCommand npgSqlCommandUnauthorized_places = new NpgsqlCommand("INSERT INTO unauthorized_places(id, unauthorized_places) VALUES (@id, @unauthorized_places)", npgSqlConnection);

                string unauthorized_places = unauthorized_places_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterUnauthorized_places = new NpgsqlParameter("@unauthorized_places", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterUnauthorized_places.Value = unauthorized_places;

                npgSqlCommandUnauthorized_places.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterUnauthorized_places });
                int count = npgSqlCommandUnauthorized_places.ExecuteNonQuery();
            }

            //date_deduction_library

            RecordField[] date_deduction_library_records = record.Fields.GetField("55").ToArray();
            foreach (var date_deduction_library_record in date_deduction_library_records)
            {
                NpgsqlCommand npgSqlCommandDate_deduction_library = new NpgsqlCommand("INSERT INTO date_deduction_library(id, date, place_registration, order_number, cause) VALUES (@id, @date, @place_registration, @order_number, @cause)", npgSqlConnection);

                string date = date_deduction_library_record.GetFieldText();
                string place_registration = date_deduction_library_record.GetSubFieldText('C', 0);
                string order_number = date_deduction_library_record.GetSubFieldText('A', 0);
                string cause = date_deduction_library_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDate = new NpgsqlParameter("@date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPlace_registration = new NpgsqlParameter("@place_registration", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterOrder_number = new NpgsqlParameter("@order_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCause = new NpgsqlParameter("@cause", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDate.Value = date;
                npgSqlParameterPlace_registration.Value = place_registration;
                npgSqlParameterOrder_number.Value = order_number;
                npgSqlParameterCause.Value = cause;

                npgSqlCommandDate_deduction_library.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDate, npgSqlParameterPlace_registration, npgSqlParameterOrder_number, npgSqlParameterCause });
                int count = npgSqlCommandDate_deduction_library.ExecuteNonQuery();
            }


            //internal_binary_resourse

            RecordField[] internal_binary_resourse_records = record.Fields.GetField("953").ToArray();
            foreach (var internal_binary_resourse_record in internal_binary_resourse_records)
            {
                NpgsqlCommand npgSqlCommandInternal_binary_resourse = new NpgsqlCommand("INSERT INTO internal_binary_resourse(id, type, name, binary_resourse) VALUES (@id, @type, @name_resourse, @binary_resourse)", npgSqlConnection);

                string type = internal_binary_resourse_record.GetSubFieldText('A', 0);
                string name_resourse = internal_binary_resourse_record.GetSubFieldText('T', 0);
                string binary_resourse = internal_binary_resourse_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterType = new NpgsqlParameter("@type", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterName_resourse = new NpgsqlParameter("@name_resourse", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterBinary_resourse = new NpgsqlParameter("@binary_resourse", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterType.Value = type;
                npgSqlParameterName_resourse.Value = name_resourse;
                npgSqlParameterBinary_resourse.Value = binary_resourse;

                npgSqlCommandInternal_binary_resourse.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterType, npgSqlParameterName_resourse, npgSqlParameterBinary_resourse });
                int count = npgSqlCommandInternal_binary_resourse.ExecuteNonQuery();
            }

            //ip_address

            RecordField[] ip_address_records = record.Fields.GetField("112").ToArray();
            foreach (var ip_address_record in ip_address_records)
            {
                NpgsqlCommand npgSqlCommandIp_address = new NpgsqlCommand("INSERT INTO ip_address(id, ip_address) VALUES (@id, @ip_address)", npgSqlConnection);

                string ip_address = ip_address_record.GetFieldText();

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterIp_address = new NpgsqlParameter("@ip_address", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterIp_address.Value = ip_address;

                npgSqlCommandIp_address.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterIp_address });
                int count = npgSqlCommandIp_address.ExecuteNonQuery();
            }

            //high_school_student

            RecordField[] high_school_student_records = record.Fields.GetField("90").ToArray();
            foreach (var high_school_student_record in high_school_student_records)
            {
                NpgsqlCommand npgSqlCommandHigh_school_student = new NpgsqlCommand("INSERT INTO high_school_student(id, academic_year, semester, not_translated, group_number, previous_group, number_curriculum, form_training, kind_training, contractor, individual_student_cipher, faculty, course, specialty, producing_department, expulsion) VALUES (@id, @academic_year, @semester, @not_translated, @group_number, @previous_group, @number_curriculum, @form_training, @kind_training, @contractor, @individual_student_cipher, @faculty, @course, @specialty, @producing_department, @expulsion)", npgSqlConnection);

                string academic_year = high_school_student_record.GetSubFieldText('0', 0);
                string semester = high_school_student_record.GetSubFieldText('F', 0);
                string not_translated = high_school_student_record.GetSubFieldText('1', 0);
                string group_number = high_school_student_record.GetSubFieldText('E', 0);
                string previous_group = high_school_student_record.GetSubFieldText('G', 0);
                string number_curriculum = high_school_student_record.GetSubFieldText('U', 0);
                string form_training = high_school_student_record.GetSubFieldText('O', 0);
                string kind_training = high_school_student_record.GetSubFieldText('V', 0);
                string contractor = high_school_student_record.GetSubFieldText('H', 0);
                string individual_student_cipher = high_school_student_record.GetSubFieldText('J', 0);
                string faculty = high_school_student_record.GetSubFieldText('A', 0);
                string course = high_school_student_record.GetSubFieldText('N', 0);
                string specialty = high_school_student_record.GetSubFieldText('C', 0);
                string producing_department = high_school_student_record.GetSubFieldText('D', 0);
                string expulsion = high_school_student_record.GetSubFieldText('2', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterAcademic_year = new NpgsqlParameter("@academic_year", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterSemester = new NpgsqlParameter("@semester", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterNot_translated = new NpgsqlParameter("@not_translated", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterGroup_number = new NpgsqlParameter("@group_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPrevious_group = new NpgsqlParameter("@previous_group", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterNumber_curriculum = new NpgsqlParameter("@number_curriculum", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterForm_training = new NpgsqlParameter("@form_training", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterKind_training = new NpgsqlParameter("@kind_training", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterContractor = new NpgsqlParameter("@contractor", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterIndividual_student_cipher = new NpgsqlParameter("@individual_student_cipher", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterFaculty = new NpgsqlParameter("@faculty", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCourse = new NpgsqlParameter("@course", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterSpecialty = new NpgsqlParameter("@specialty", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterProducing_department = new NpgsqlParameter("@producing_department", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterExpulsion = new NpgsqlParameter("@expulsion", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterAcademic_year.Value = academic_year;
                npgSqlParameterSemester.Value = semester;
                npgSqlParameterNot_translated.Value = not_translated;
                npgSqlParameterGroup_number.Value = group_number;
                npgSqlParameterPrevious_group.Value = previous_group;
                npgSqlParameterNumber_curriculum.Value = number_curriculum;
                npgSqlParameterForm_training.Value = form_training;
                npgSqlParameterKind_training.Value = kind_training;
                npgSqlParameterContractor.Value = contractor;
                npgSqlParameterIndividual_student_cipher.Value = individual_student_cipher;
                npgSqlParameterFaculty.Value = faculty;
                npgSqlParameterCourse.Value = course;
                npgSqlParameterSpecialty.Value = specialty;
                npgSqlParameterProducing_department.Value = producing_department;
                npgSqlParameterExpulsion.Value = expulsion;

                npgSqlCommandHigh_school_student.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterAcademic_year, npgSqlParameterSemester, npgSqlParameterNot_translated, npgSqlParameterGroup_number, npgSqlParameterPrevious_group, npgSqlParameterNumber_curriculum, npgSqlParameterForm_training, npgSqlParameterKind_training, npgSqlParameterContractor, npgSqlParameterIndividual_student_cipher, npgSqlParameterFaculty, npgSqlParameterCourse, npgSqlParameterSpecialty, npgSqlParameterProducing_department, npgSqlParameterExpulsion });
                int count = npgSqlCommandHigh_school_student.ExecuteNonQuery();
            }

            //department_discipline

            RecordField[] department_discipline_records = record.Fields.GetField("69").ToArray();
            foreach (var department_discipline_record in department_discipline_records)
            {
                NpgsqlCommand npgSqlCommandDepartment_discipline = new NpgsqlCommand("INSERT INTO department_discipline(id, department, subject, subject_id) VALUES (@id, @department, @subject, @subject_id)", npgSqlConnection);

                string department = department_discipline_record.GetSubFieldText('B', 0);
                string subject = department_discipline_record.GetSubFieldText('D', 0);
                string subject_id = department_discipline_record.GetSubFieldText('W', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDepartment = new NpgsqlParameter("@department", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterSubject = new NpgsqlParameter("@subject", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterSubject_id = new NpgsqlParameter("@subject_id", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDepartment.Value = department;
                npgSqlParameterSubject.Value = subject;
                npgSqlParameterSubject_id.Value = subject_id;

                npgSqlCommandDepartment_discipline.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDepartment, npgSqlParameterSubject, npgSqlParameterSubject_id });
                int count = npgSqlCommandDepartment_discipline.ExecuteNonQuery();
            }

            //profile_IRI

            RecordField[] profile_IRI_records = record.Fields.GetField("140").ToArray();
            foreach (var profile_IRI_record in profile_IRI_records)
            {
                NpgsqlCommand npgSqlCommandProfile_IRI = new NpgsqlCommand("INSERT INTO profile_IRI(id, profile_status, profile_code, description_profile, profile_language_IRBIS_query, service_intervals, last_maintenance_date, profile_creation_date, bauilee, list_DB, name_tabular_form, profile_type) VALUES (@id, @profile_status, @profile_code, @description_profile, @profile_language_IRBIS_query, @service_intervals, @last_maintenance_date, @profile_creation_date, @bauilee, @list_DB, @name_tabular_form, @profile_type)", npgSqlConnection);

                string profile_status = profile_IRI_record.GetSubFieldText('A', 0);
                string profile_code = profile_IRI_record.GetSubFieldText('B', 0);
                string description_profile = profile_IRI_record.GetSubFieldText('C', 0);
                string profile_language_IRBIS_query = profile_IRI_record.GetSubFieldText('D', 0);
                string service_intervals = profile_IRI_record.GetSubFieldText('E', 0);
                string last_maintenance_date = profile_IRI_record.GetSubFieldText('F', 0);
                string profile_creation_date = profile_IRI_record.GetSubFieldText('G', 0);
                string bauilee = profile_IRI_record.GetSubFieldText('H', 0);
                string list_DB = profile_IRI_record.GetSubFieldText('I', 0);
                string name_tabular_form = profile_IRI_record.GetSubFieldText('K', 0);
                string profile_type = profile_IRI_record.GetSubFieldText('L', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterProfile_status = new NpgsqlParameter("@profile_status", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterProfile_code = new NpgsqlParameter("@profile_code", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDescription_profile = new NpgsqlParameter("@description_profile", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterProfile_language_IRBIS_query = new NpgsqlParameter("@profile_language_IRBIS_query", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterService_intervals = new NpgsqlParameter("@service_intervals", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterLast_maintenance_date = new NpgsqlParameter("@last_maintenance_date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterProfile_creation_date = new NpgsqlParameter("@profile_creation_date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterBauilee = new NpgsqlParameter("@bauilee", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterList_DB = new NpgsqlParameter("@list_DB", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterName_tabular_form = new NpgsqlParameter("@name_tabular_form", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterProfile_type = new NpgsqlParameter("@profile_type", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterProfile_status.Value = profile_status;
                npgSqlParameterProfile_code.Value = profile_code;
                npgSqlParameterDescription_profile.Value = description_profile;
                npgSqlParameterProfile_language_IRBIS_query.Value = profile_language_IRBIS_query;
                npgSqlParameterService_intervals.Value = service_intervals;
                npgSqlParameterLast_maintenance_date.Value = last_maintenance_date;
                npgSqlParameterProfile_creation_date.Value = profile_creation_date;
                npgSqlParameterBauilee.Value = bauilee;
                npgSqlParameterList_DB.Value = list_DB;
                npgSqlParameterName_tabular_form.Value = name_tabular_form;
                npgSqlParameterProfile_type.Value = profile_type;

                npgSqlCommandProfile_IRI.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterProfile_status, npgSqlParameterProfile_code, npgSqlParameterDescription_profile, npgSqlParameterProfile_language_IRBIS_query, npgSqlParameterService_intervals, npgSqlParameterLast_maintenance_date, npgSqlParameterProfile_creation_date, npgSqlParameterBauilee, npgSqlParameterList_DB, npgSqlParameterName_tabular_form, npgSqlParameterProfile_type});
                int count = npgSqlCommandProfile_IRI.ExecuteNonQuery();
            }

            //information_to_take_book

            RecordField[] information_to_take_book_records = record.Fields.GetField("40").ToArray();
            foreach (var information_to_take_book_record in information_to_take_book_records)
            {
                NpgsqlCommand npgSqlCommandInformation_to_take_book = new NpgsqlCommand("INSERT INTO information_to_take_book(id, code_publishing, copy, title_publication, place, place_issue, date_issue, hz, estimated_return, hz2, database, copy_2, bailee) VALUES (@id, @code_publishing, @copy, @title_publication, @place, @place_issue, @date_issue, @hz, @estimated_return, @hz2, @database, @copy_2, @bailee)", npgSqlConnection);

                string code_publishing = information_to_take_book_record.GetSubFieldText('A', 0);
                string copy = information_to_take_book_record.GetSubFieldText('B', 0);
                string title_publication = information_to_take_book_record.GetSubFieldText('C', 0);
                string place = information_to_take_book_record.GetSubFieldText('K', 0);
                string place_issue = information_to_take_book_record.GetSubFieldText('V', 0);
                string date_issue = information_to_take_book_record.GetSubFieldText('D', 0);
                string hz = information_to_take_book_record.GetSubFieldText('1', 0);
                string estimated_return = information_to_take_book_record.GetSubFieldText('E', 0);
                string hz2 = information_to_take_book_record.GetSubFieldText('F', 0);
                string database = information_to_take_book_record.GetSubFieldText('G', 0);
                string copy_2 = information_to_take_book_record.GetSubFieldText('H', 0);
                string bailee = information_to_take_book_record.GetSubFieldText('I', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterCode_publishing = new NpgsqlParameter("@code_publishing", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCopy = new NpgsqlParameter("@copy", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterTitle_publication = new NpgsqlParameter("@title_publication", NpgsqlTypes.NpgsqlDbType.Text);
                NpgsqlParameter npgSqlParameterPlace = new NpgsqlParameter("@place", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPlace_issue = new NpgsqlParameter("@place_issue", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDate_issue = new NpgsqlParameter("@date_issue", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterHz = new NpgsqlParameter("@hz", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterEstimated_return = new NpgsqlParameter("@estimated_return", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterHz2 = new NpgsqlParameter("@hz2", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDatabase = new NpgsqlParameter("@database", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterCopy_2 = new NpgsqlParameter("@copy_2", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterBailee = new NpgsqlParameter("@bailee", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterCode_publishing.Value = code_publishing;
                npgSqlParameterCopy.Value = copy;
                npgSqlParameterTitle_publication.Value = title_publication;
                npgSqlParameterPlace.Value = place;
                npgSqlParameterPlace_issue.Value = place_issue;
                npgSqlParameterDate_issue.Value = date_issue;
                npgSqlParameterHz.Value = hz;
                npgSqlParameterEstimated_return.Value = estimated_return;
                npgSqlParameterHz2.Value = hz2;
                npgSqlParameterDatabase.Value = database;
                npgSqlParameterCopy_2.Value = copy_2;
                npgSqlParameterBailee.Value = bailee;

                npgSqlCommandInformation_to_take_book.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterCode_publishing, npgSqlParameterCopy, npgSqlParameterTitle_publication, npgSqlParameterPlace, npgSqlParameterPlace_issue, npgSqlParameterDate_issue, npgSqlParameterHz, npgSqlParameterEstimated_return, npgSqlParameterHz2, npgSqlParameterDatabase, npgSqlParameterCopy_2, npgSqlParameterBailee });
                int count = npgSqlCommandInformation_to_take_book.ExecuteNonQuery();
            }

            //issuance_book_absence_EC

            RecordField[] issuance_book_absence_EC_records = record.Fields.GetField("200").ToArray();
            foreach (var issuance_book_absence_EC_record in issuance_book_absence_EC_records)
            {
                NpgsqlCommand npgSqlCommandIssuance_book_absence_EC = new NpgsqlCommand("INSERT INTO issuance_book_absence_EC(id, name_db_catalog, type_publication_code, book_title, doublet_record, uncharacteristic_title, 1st_author, 2nd_author, 3rd_author, role, designation_number_volume, volume_title, year_publishing, number_pages, shelving_cipher, place_storage, inventory_number, barcode, date_receipt_copy, number_copies, date_issue, place_issue, return_date, double_check_cancel, order_bronepolku) VALUES (@id, @name_db_catalog, @type_publication_code, @book_title, @doublet_record, @uncharacteristic_title, @1st_author, @2nd_author, @3rd_author, @role, @designation_number_volume, @volume_title, @year_publishing, @number_pages, @shelving_cipher, @place_storage, @inventory_number, @barcode, @date_receipt_copy, @number_copies, @date_issue, @place_issue, @return_date, @double_check_cancel, @order_bronepolku)", npgSqlConnection);

                string name_db_catalog = issuance_book_absence_EC_record.GetSubFieldText('G', 0);
                string type_publication_code = issuance_book_absence_EC_record.GetSubFieldText('V', 0);
                string book_title = issuance_book_absence_EC_record.GetSubFieldText('C', 0);
                string doublet_record = issuance_book_absence_EC_record.GetSubFieldText('!', 0);
                string uncharacteristic_title = issuance_book_absence_EC_record.GetSubFieldText('U', 0);
                string author_1st = issuance_book_absence_EC_record.GetSubFieldText('F', 0);
                string author_2nd = issuance_book_absence_EC_record.GetSubFieldText('2', 0);
                string author_3rd = issuance_book_absence_EC_record.GetSubFieldText('3', 0);
                string role = issuance_book_absence_EC_record.GetSubFieldText('X', 0);
                string designation_number_volume = issuance_book_absence_EC_record.GetSubFieldText('H', 0);
                string volume_title = issuance_book_absence_EC_record.GetSubFieldText('I', 0);
                string year_publishing = issuance_book_absence_EC_record.GetSubFieldText('J', 0);
                string number_pages = issuance_book_absence_EC_record.GetSubFieldText('S', 0);
                string shelving_cipher = issuance_book_absence_EC_record.GetSubFieldText('A', 0);
                string place_storage = issuance_book_absence_EC_record.GetSubFieldText('M', 0);
                string inventory_number = issuance_book_absence_EC_record.GetSubFieldText('B', 0);
                string barcode = issuance_book_absence_EC_record.GetSubFieldText('K', 0);
                string date_receipt_copy = issuance_book_absence_EC_record.GetSubFieldText('P', 0);
                string number_copies = issuance_book_absence_EC_record.GetSubFieldText('1', 0);
                string date_issue = issuance_book_absence_EC_record.GetSubFieldText('D', 0);
                string place_issue = issuance_book_absence_EC_record.GetSubFieldText('W', 0);
                string return_date = issuance_book_absence_EC_record.GetSubFieldText('E', 0);
                string double_check_cancel = issuance_book_absence_EC_record.GetSubFieldText('9', 0);
                string order_bronepolku = issuance_book_absence_EC_record.GetSubFieldText('R', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterName_db_catalog = new NpgsqlParameter("@name_db_catalog", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterType_publication_code = new NpgsqlParameter("@type_publication_code", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterBook_title = new NpgsqlParameter("@book_title", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDoublet_record = new NpgsqlParameter("@doublet_record", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterUncharacteristic_title = new NpgsqlParameter("@uncharacteristic_title", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameter1st_author = new NpgsqlParameter("@1st_author", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameter2nd_author = new NpgsqlParameter("@2nd_author", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameter3rd_author = new NpgsqlParameter("@3rd_author", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterRole = new NpgsqlParameter("@role", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDesignation_number_volume = new NpgsqlParameter("@designation_number_volume", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterVolume_title = new NpgsqlParameter("@volume_title", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterYear_publishing = new NpgsqlParameter("@year_publishing", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterNumber_pages = new NpgsqlParameter("@number_pages", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterShelving_cipher = new NpgsqlParameter("@shelving_cipher", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPlace_storage = new NpgsqlParameter("@place_storage", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterInventory_number = new NpgsqlParameter("@inventory_number", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterBarcode = new NpgsqlParameter("@barcode", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDate_receipt_copy = new NpgsqlParameter("@date_receipt_copy", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterNumber_copies = new NpgsqlParameter("@number_copies", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDate_issue = new NpgsqlParameter("@date_issue", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterPlace_issue = new NpgsqlParameter("@place_issue", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterReturn_date = new NpgsqlParameter("@return_date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterDouble_check_cancel = new NpgsqlParameter("@double_check_cancel", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterOrder_bronepolku = new NpgsqlParameter("@order_bronepolku", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterName_db_catalog.Value = name_db_catalog;
                npgSqlParameterType_publication_code.Value = type_publication_code;
                npgSqlParameterBook_title.Value = book_title;
                npgSqlParameterDoublet_record.Value = doublet_record;
                npgSqlParameterUncharacteristic_title.Value = uncharacteristic_title;
                npgSqlParameter1st_author.Value = author_1st;
                npgSqlParameter2nd_author.Value = author_2nd;
                npgSqlParameter3rd_author.Value = author_3rd;
                npgSqlParameterRole.Value = role;
                npgSqlParameterDesignation_number_volume.Value = designation_number_volume;
                npgSqlParameterVolume_title.Value = volume_title;
                npgSqlParameterYear_publishing.Value = year_publishing;
                npgSqlParameterNumber_pages.Value = number_pages;
                npgSqlParameterShelving_cipher.Value = shelving_cipher;
                npgSqlParameterPlace_storage.Value = place_storage;
                npgSqlParameterInventory_number.Value = inventory_number;
                npgSqlParameterBarcode.Value = barcode;
                npgSqlParameterDate_receipt_copy.Value = date_receipt_copy;
                npgSqlParameterNumber_copies.Value = number_copies;
                npgSqlParameterDate_issue.Value = date_issue;
                npgSqlParameterPlace_issue.Value = place_issue;
                npgSqlParameterReturn_date.Value = return_date;
                npgSqlParameterDouble_check_cancel.Value = double_check_cancel;
                npgSqlParameterOrder_bronepolku.Value = order_bronepolku;

                npgSqlCommandIssuance_book_absence_EC.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterName_db_catalog, npgSqlParameterType_publication_code, npgSqlParameterBook_title, npgSqlParameterDoublet_record, npgSqlParameterUncharacteristic_title, npgSqlParameter1st_author, npgSqlParameter2nd_author, npgSqlParameter3rd_author, npgSqlParameterRole, npgSqlParameterDesignation_number_volume, npgSqlParameterVolume_title, npgSqlParameterYear_publishing, npgSqlParameterNumber_pages, npgSqlParameterShelving_cipher, npgSqlParameterPlace_storage, npgSqlParameterInventory_number, npgSqlParameterBarcode, npgSqlParameterDate_receipt_copy, npgSqlParameterNumber_copies, npgSqlParameterDate_issue, npgSqlParameterPlace_issue, npgSqlParameterReturn_date, npgSqlParameterDouble_check_cancel, npgSqlParameterOrder_bronepolku });
                int count = npgSqlCommandIssuance_book_absence_EC.ExecuteNonQuery();
            }

            //create_record

            RecordField[] create_record_records = record.Fields.GetField("31").ToArray();
            foreach (var create_record_record in create_record_records)
            {
                NpgsqlCommand npgSqlCommandCreate_record = new NpgsqlCommand("INSERT INTO create_record(id, date, full_name) VALUES (@id, @date, @full_name)", npgSqlConnection);

                string date = create_record_record.GetSubFieldText('A', 0);
                string full_name = create_record_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDate = new NpgsqlParameter("@date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterFull_name = new NpgsqlParameter("@full_name", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDate.Value = date;
                npgSqlParameterFull_name.Value = full_name;
                npgSqlCommandCreate_record.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDate, npgSqlParameterFull_name });
                int count = npgSqlCommandCreate_record.ExecuteNonQuery();
            }

            //edit_record

            RecordField[] edit_record_records = record.Fields.GetField("907").ToArray();
            foreach (var edit_record_record in edit_record_records)
            {
                NpgsqlCommand npgSqlCommandEdit_record = new NpgsqlCommand("INSERT INTO edit_record(id, date, full_name) VALUES (@id, @date, @full_name)", npgSqlConnection);

                string date = edit_record_record.GetSubFieldText('A', 0);
                string full_name = edit_record_record.GetSubFieldText('B', 0);

                NpgsqlParameter npgSqlParameterId = new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer);
                NpgsqlParameter npgSqlParameterDate = new NpgsqlParameter("@date", NpgsqlTypes.NpgsqlDbType.Varchar);
                NpgsqlParameter npgSqlParameterFull_name = new NpgsqlParameter("@full_name", NpgsqlTypes.NpgsqlDbType.Varchar);

                npgSqlParameterId.Value = id;
                npgSqlParameterDate.Value = date;
                npgSqlParameterFull_name.Value = full_name;

                npgSqlCommandEdit_record.Parameters.AddRange(new NpgsqlParameter[] { npgSqlParameterId, npgSqlParameterDate, npgSqlParameterFull_name });
                int count = npgSqlCommandEdit_record.ExecuteNonQuery();
            }

            return true;
        }
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Postgresql connect");
                //String connectionString = "Server=localhost;Port=5432;User=postgres;Password='';Database=work;";
                String connectionString = "Server=192.168.28.17;Port=5432;User=postgres;Password='123test123';Database=work;";
                NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
                npgSqlConnection.Open();
                Console.WriteLine("Postgresql connected");

                Console.WriteLine("Irbris connecting");
                ManagedClient64 irbisConnect = new ManagedClient64();
                irbisConnect.ParseConnectionString("host=127.0.0.1;port=6452;user=СТА;password=СТА;");
                irbisConnect.Connect();
                Console.WriteLine("Irbris connected");

                // Делаем переключение на базу RDR
                irbisConnect.PushDatabase("RDR");

                // Алфавит по которому будем производить циклический поиск
                string[] alphabet = new string[] {
                    "А","Б","В","Г","Ґ","Д","Е","Є","Ё","Ж","З","И","І","Ї","Й","К","Л","М","Н",
                    "О","П","Р","С","Т","У","Ф","Х","Ц","Ч","Ш","Щ","Ъ","Ы","Ь","Э","Ю","Я",
                    "а","б","в","г","ґ","д","е","є","ё","ж","з","и","і","ї","й","к","л","м","н",
                    "о","п","р","с","т","у","ф","х","ц","ч","ш","щ","ъ","ы","ь","э","ю","я",
                };

                // Осуществляем циклический поиск
                List<int> usersList = new List<int>();
                for (int i = 0; i < alphabet.Length; i++)
                {
                    int[] found = irbisConnect.Search("\"A={0}$\"", alphabet[i]);

                    for (int j = 0; j < found.Length; j++)
                    {

                        usersList.Add(found[j]);
                    }
                }

                // Преобразование списка в массив с удалением дубликатов
                int[] foundRecords = usersList.Distinct().ToArray();

                // Сортировка списка ID по возрастанию
                Array.Sort(foundRecords);

                int recordsCount = foundRecords.Length;
                    

                for (int i = 0; i < recordsCount - 1; i++)
                {
                    IrbisRecord record = irbisConnect.ReadRecord(foundRecords[i]);
                    Insert(npgSqlConnection, record);
                }


                Console.WriteLine("Irbris disconnect");
                irbisConnect.Disconnect();
                Console.WriteLine("Irbris disconnected");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}