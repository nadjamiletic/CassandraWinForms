using Cassandra;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region Grad
      /*  public static Grad GetGrad(string gradid)
        {
            ISession session = SessionManager.GetSession();
            Grad grad = new Grad();

            if (session == null)
                return null;

            Row gradData = session.Execute("select * from \"Grad\" where \"gradid\"='"+gradid+"'").;
            
            if (gradData != null)
            {
                grad.gradid = gradData["gradid"] != null ? gradData["gradid"].ToString() : string.Empty;
                //grad.nazivgrada = gradData["nazivgrada"] != null ? gradData["nazivgrada"].ToString() : string.Empty;
                grad.drzava = gradData["drzava"] != null ? gradData["drzava"].ToString() : string.Empty;
                grad.stanica= gradData["stanica"] != null ? gradData["stanica"].ToString() : string.Empty;


            }

            return grad;
        }*/

        public static List<Grad> GetGradove()
        {
            ISession session = SessionManager.GetSession();
            List<Grad> gradovi = new List<Grad>();


            if (session == null)
                return null;

            var gradoviData = session.Execute("select * from \"Grad\"");


            foreach (var gradData in gradoviData)
            {
                Grad grad = new Grad();
         
                grad.gradid = gradData["gradid"] != null ? gradData["gradid"].ToString() : string.Empty;
                //grad.nazivgrada = gradData["nazivgrada"] != null ? gradData["nazivgrada"].ToString() : string.Empty;
                grad.drzava = gradData["drzava"] != null ? gradData["drzava"].ToString() : string.Empty;
                grad.stanica = gradData["stanica"] != null ? gradData["stanica"].ToString() : string.Empty;
                gradovi.Add(grad);
            }



            return gradovi;
        }

        public static List<Grad> GetGradove(string gradid)
        {
            ISession session = SessionManager.GetSession();
            List<Grad> gradovi = new List<Grad>();


            if (session == null)
                return null;

            var gradoviData = session.Execute("select * from \"Grad\" where \"gradid\"='" + gradid + "'");


            foreach (var gradData in gradoviData)
            {
                Grad grad = new Grad();

                grad.gradid = gradData["gradid"] != null ? gradData["gradid"].ToString() : string.Empty;
                //grad.nazivgrada = gradData["nazivgrada"] != null ? gradData["nazivgrada"].ToString() : string.Empty;
                grad.drzava = gradData["drzava"] != null ? gradData["drzava"].ToString() : string.Empty;
                grad.stanica = gradData["stanica"] != null ? gradData["stanica"].ToString() : string.Empty;
                gradovi.Add(grad);
            }



            return gradovi;
        }

        public static void AddGrad(string gradid,string drzava,string stanica)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet gradData = session.Execute("insert into \"Grad\" (\"gradid\", drzava,\"stanica\")  values ('" + gradid +"','"+ drzava+ "','"+ stanica+"')");
            
        }

        public static void DeleteGrad(string gradid)
        {
            ISession session = SessionManager.GetSession();
            Grad grad = new Grad();

            if (session == null)
                return;

            RowSet gradData = session.Execute("delete from \"Grad\" where \"gradid\" = '" + gradid + "'");

        }

        #endregion

        #region Reka

        /* public static Reka GetReka(string rekaid)
         {
             ISession session = SessionManager.GetSession();
             Reka reka = new Reka();

             if (session == null)
                 return null;

             Row rekaData = session.Execute("select * from \"Reka\" where rekaid='" + rekaid + "'").FirstOrDefault();

             if (rekaData != null)
             {
                 reka.rekaid = rekaData["rekaid"] != null ? rekaData["rekaid"].ToString() : string.Empty;
                 //reka.nazivreke = rekaData["nazivreke"] != null ? rekaData["nazivreke"].ToString() : string.Empty;
                 reka.gradid= rekaData["gradid"] != null ? rekaData["gradid"].ToString() : string.Empty;
                 reka.stanicaid= rekaData["stanicaid"] != null ? rekaData["stanicaid"].ToString() : string.Empty;

             }

             return reka;
         }*/
        public static List<Reka> GetReku(string rekaid)
        {
            ISession session = SessionManager.GetSession();
            List<Reka> reke = new List<Reka>();

            if (session == null)
                return null;

            var rekeData = session.Execute("select * from \"Reka\" where rekaid = '" + rekaid + "'");


            foreach (var rekaData in rekeData)
            {
                Reka reka = new Reka();
                
                reka.stanicaid = rekaData["stanicaid"] != null ? rekaData["stanicaid"].ToString() : string.Empty;
                
                reke.Add(reka);
            }


            return reke;
        }

        public static List<Reka> GetReke()
        {
            ISession session = SessionManager.GetSession();
            List<Reka> reke = new List<Reka>();

            if (session == null)
                return null;

            var rekeData = session.Execute("select * from \"Reka\"");


            foreach (var rekaData in rekeData)
            {
                Reka reka = new Reka();
                reka.rekaid = rekaData["rekaid"] != null ? rekaData["rekaid"].ToString() : string.Empty;
                reka.gradid= rekaData["gradid"] != null ? rekaData["gradid"].ToString() : string.Empty;
                reka.stanicaid= rekaData["stanicaid"] != null ? rekaData["stanicaid"].ToString() : string.Empty;
                //reka.nazivreke = rekaData["nazivreke"] != null ? rekaData["nazivreke"].ToString() : string.Empty;
                reke.Add(reka);
            }


            return reke;
        }

        public static void AddReka(string rekaid,string gradid, string stanicaid)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet rekaData = session.Execute("insert into \"Reka\"(rekaid, gradid, stanicaid) values ('" + rekaid + "','" + gradid + "','" + stanicaid + "')");

        }

        public static void DeleteReka(string rekaid)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet rekaData = session.Execute("delete from \"Reka\" where rekaid = '" + rekaid + "'");

        }

        #endregion

        #region StanjeStanica
        /*
                public static StanjeStanica GetPodaci(string stanicaid)
                {
                    ISession session = SessionManager.GetSession();
                    StanjeStanica podaci = new StanjeStanica();

                    if (session == null)
                        return null;

                    Row podaciData = session.Execute("select * from \"StanjeStanica\" where \"stanicaid\"='" + stanicaid + "'").FirstOrDefault();

                    if (podaciData != null)
                    {

                        podaci.stanicaid = podaciData["stanicaid"] != null ? podaciData["stanicaid"].ToString() : string.Empty;
                        podaci.rekaid = podaciData["rekaid"] != null ? podaciData["rekaid"].ToString() : string.Empty;
                        podaci.vodostaj = podaciData["vodostaj"] != null ? podaciData["vodostaj"].GetHashCode() :0;
                        podaci.promenavodostaja = podaciData["promenavodostaja"] != null ? podaciData["promenavodostaja"].GetHashCode() : 0;
                        podaci.proticaj = podaciData["proticaj"] != null ? podaciData["proticaj"].GetHashCode() : 0;
                        podaci.temperatura = podaciData["temperatura"] != null ? podaciData["temperatura"].GetHashCode() : 0;
                        podaci.sat = podaciData["sat"] != null ? podaciData["sat"].GetHashCode() : 0;
                        podaci.dan = podaciData["dan"] != null ? podaciData["dan"].GetHashCode() : 0;
                        podaci.mesec = podaciData["mesec"] != null ? podaciData["mesec"].ToString() : string.Empty;
                    }

                    return podaci;
                }
                */

        public static List<StanjeStanica> GetPodaci(string stanicaid)
        {
            ISession session = SessionManager.GetSession();
            List<StanjeStanica> podacii = new List<StanjeStanica>();

            if (session == null)
                return null;

            var podaciiData = session.Execute("select * from \"StanjeStanica\" where \"stanicaid\"='" + stanicaid + "'");


            foreach (Row podaciData in podaciiData)
            {
                StanjeStanica podaci = new StanjeStanica();
                podaci.stanicaid = podaciData["stanicaid"] != null ? podaciData["stanicaid"].ToString() : string.Empty;
                podaci.rekaid = podaciData["rekaid"] != null ? podaciData["rekaid"].ToString() : string.Empty;
                podaci.vodostaj = podaciData["vodostaj"] != null ? podaciData["vodostaj"].GetHashCode() : 0;
                podaci.promenavodostaja = podaciData["promenavodostaja"] != null ? podaciData["promenavodostaja"].GetHashCode() : 0;
                podaci.proticaj = podaciData["proticaj"] != null ? podaciData["proticaj"].GetHashCode() : 0;
                podaci.temperatura = podaciData["temperatura"] != null ? podaciData["temperatura"].GetHashCode() : 0;
                podaci.sat = podaciData["sat"] != null ? podaciData["sat"].GetHashCode() : 0;
                podaci.dan = podaciData["dan"] != null ? podaciData["dan"].GetHashCode() : 0;
                podaci.mesec = podaciData["mesec"] != null ? podaciData["mesec"].ToString() : string.Empty;
                podacii.Add(podaci);
            }


            return podacii;
        }

        public static List<StanjeStanica> GetPodaci(string stanicaid, string rekaid)
        {
            ISession session = SessionManager.GetSession();
            List<StanjeStanica> podacii = new List<StanjeStanica>();

            if (session == null)
                return null;

            var podaciiData = session.Execute("select * from \"StanjeStanica\" where \"stanicaid\"='" + stanicaid + "' and \"rekaid\"='" + rekaid + "'");


            foreach (Row podaciData in podaciiData)
            {
                StanjeStanica podaci = new StanjeStanica();
                podaci.stanicaid = podaciData["stanicaid"] != null ? podaciData["stanicaid"].ToString() : string.Empty;
                podaci.rekaid = podaciData["rekaid"] != null ? podaciData["rekaid"].ToString() : string.Empty;
                podaci.vodostaj = podaciData["vodostaj"] != null ? podaciData["vodostaj"].GetHashCode() : 0;
                podaci.promenavodostaja = podaciData["promenavodostaja"] != null ? podaciData["promenavodostaja"].GetHashCode() : 0;
                podaci.proticaj = podaciData["proticaj"] != null ? podaciData["proticaj"].GetHashCode() : 0;
                podaci.temperatura = podaciData["temperatura"] != null ? podaciData["temperatura"].GetHashCode() : 0;
                podaci.sat = podaciData["sat"] != null ? podaciData["sat"].GetHashCode() : 0;
                podaci.dan = podaciData["dan"] != null ? podaciData["dan"].GetHashCode() : 0;
                podaci.mesec = podaciData["mesec"] != null ? podaciData["mesec"].ToString() : string.Empty;
                podacii.Add(podaci);
            }


            return podacii;
        }

        public static List<StanjeStanica> GetPodaci(string stanicaid,string rekaid,string mesec)
        {
            ISession session = SessionManager.GetSession();
            List<StanjeStanica> podacii = new List<StanjeStanica>();

            if (session == null)
                return null;
            
            var podaciiData = session.Execute("select * from \"StanjeStanica\" where \"stanicaid\"='" + stanicaid + "' and \"rekaid\"='"+rekaid+"' and \"mesec\"='"+mesec+"'");


            foreach (Row podaciData in podaciiData)
            {
                StanjeStanica podaci = new StanjeStanica();
                podaci.stanicaid = podaciData["stanicaid"] != null ? podaciData["stanicaid"].ToString() : string.Empty;
                podaci.rekaid = podaciData["rekaid"] != null ? podaciData["rekaid"].ToString() : string.Empty;
                podaci.vodostaj = podaciData["vodostaj"] != null ? podaciData["vodostaj"].GetHashCode() : 0;
                podaci.promenavodostaja = podaciData["promenavodostaja"] != null ? podaciData["promenavodostaja"].GetHashCode() : 0;
                podaci.proticaj = podaciData["proticaj"] != null ? podaciData["proticaj"].GetHashCode() : 0;
                podaci.temperatura = podaciData["temperatura"] != null ? podaciData["temperatura"].GetHashCode() : 0;
                podaci.sat = podaciData["sat"] != null ? podaciData["sat"].GetHashCode() : 0;
                podaci.dan = podaciData["dan"] != null ? podaciData["dan"].GetHashCode() : 0;
                podaci.mesec = podaciData["mesec"] != null ? podaciData["mesec"].ToString() : string.Empty;
                podacii.Add(podaci);
            }


            return podacii;
        }

        public static List<StanjeStanica> GetPodaci(string stanicaid, string rekaid, string mesec,int dan)
        {
            ISession session = SessionManager.GetSession();
            List<StanjeStanica> podacii = new List<StanjeStanica>();

            if (session == null)
                return null;

            var podaciiData = session.Execute("select * from \"StanjeStanica\" where \"stanicaid\"='" + stanicaid + "' and \"rekaid\"='" + rekaid + "' and \"mesec\"='" + mesec +"' and \"dan\"="+dan +"");


            foreach (Row podaciData in podaciiData)
            {
                StanjeStanica podaci = new StanjeStanica();
                podaci.stanicaid = podaciData["stanicaid"] != null ? podaciData["stanicaid"].ToString() : string.Empty;
                podaci.rekaid = podaciData["rekaid"] != null ? podaciData["rekaid"].ToString() : string.Empty;
                podaci.vodostaj = podaciData["vodostaj"] != null ? podaciData["vodostaj"].GetHashCode() : 0;
                podaci.promenavodostaja = podaciData["promenavodostaja"] != null ? podaciData["promenavodostaja"].GetHashCode() : 0;
                podaci.proticaj = podaciData["proticaj"] != null ? podaciData["proticaj"].GetHashCode() : 0;
                podaci.temperatura = podaciData["temperatura"] != null ? podaciData["temperatura"].GetHashCode() : 0;
                podaci.sat = podaciData["sat"] != null ? podaciData["sat"].GetHashCode() : 0;
                podaci.dan = podaciData["dan"] != null ? podaciData["dan"].GetHashCode() : 0;
                podaci.mesec = podaciData["mesec"] != null ? podaciData["mesec"].ToString() : string.Empty;
                podacii.Add(podaci);
            }


            return podacii;
        }

        public static List<StanjeStanica> GetPodaci()
        {
            ISession session = SessionManager.GetSession();
            List<StanjeStanica> podacii = new List<StanjeStanica>();

            if (session == null)
                return null;

            var podaciiData = session.Execute("select * from \"StanjeStanica\"");


            foreach (Row podaciData in podaciiData)
            {
                StanjeStanica podaci = new StanjeStanica();
                podaci.stanicaid = podaciData["stanicaid"] != null ? podaciData["stanicaid"].ToString() : string.Empty;
                podaci.rekaid = podaciData["rekaid"] != null ? podaciData["rekaid"].ToString() : string.Empty;
                podaci.vodostaj = podaciData["vodostaj"] != null ? podaciData["vodostaj"].GetHashCode() : 0;
                podaci.promenavodostaja = podaciData["promenavodostaja"] != null ? podaciData["promenavodostaja"].GetHashCode() : 0;
                podaci.proticaj = podaciData["proticaj"] != null ? podaciData["proticaj"].GetHashCode() : 0;
                podaci.temperatura = podaciData["temperatura"] != null ? podaciData["temperatura"].GetHashCode() : 0;
                podaci.sat = podaciData["sat"] != null ? podaciData["sat"].GetHashCode() : 0;
                podaci.dan = podaciData["dan"] != null ? podaciData["dan"].GetHashCode() : 0;
                podaci.mesec = podaciData["mesec"] != null ? podaciData["mesec"].ToString() : string.Empty;
                podacii.Add(podaci);
            }


            return podacii;
        }

        public static void AddPodaci(string stanicaid,string rekaid,string mesec,int vodostaj,int promenavodostaja,int proticaj,int temperatura,int sat,int dan)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet podaciData = session.Execute("insert into \"StanjeStanica\"(\"stanicaid\", \"rekaid\",\"mesec\", vodostaj, promenavodostaja, proticaj, temperatura, sat,dan) values ('" + stanicaid + "','" + rekaid + "','" + mesec +"',"+vodostaj+","+promenavodostaja+","+proticaj+","+temperatura+","+sat+","+dan+")");
                                                                                                     
        }

        public static void DeletePodaci(string stanicaid)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet podaciData = session.Execute("delete from \"StanjeStanica\" where \"stanicaid\" = '" + stanicaid + "'");

        }

        #endregion

        #region Komentar


        public static List<Komentar> GetKomentare()
        {
            ISession session = SessionManager.GetSession();
            List<Komentar> komentari = new List<Komentar>();


            if (session == null)
                return null;

            var komentariData = session.Execute("select * from \"Komentar\"");


            foreach (var komentarData in komentariData)
            {
                Komentar kom = new Komentar();


                kom.autor = komentarData["autor"] != null ? komentarData["autor"].ToString() : string.Empty;
                kom.sadrzaj = komentarData["sadrzaj"] != null ? komentarData["sadrzaj"].ToString() : string.Empty;
                kom.brlike = komentarData["brlike"] != null ? komentarData["brlike"].GetHashCode() : 0;
                kom.brunlike = komentarData["brunlike"] != null ? komentarData["brunlike"].GetHashCode() : 0;

                komentari.Add(kom);
            }



            return komentari;
        }



        public static void AddKomentar(string autor, string sadrzaj, int brlike, int brunlike)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet komData = session.Execute("insert into \"Komentar\" (\"autor\",\"sadrzaj\",brlike,brunlike)  values ('" + autor + "','" + sadrzaj + "'," + brlike + "," + brunlike + ")");

        }

        #endregion
    }
}
