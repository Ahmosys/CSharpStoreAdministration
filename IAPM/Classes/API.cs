using System;
using System.Net;


namespace IAPM.Technique
{
    public static class API
    {
        /// <summary>
        /// Permet de récupérer l'adresse IP publique du client.
        /// </summary>
        /// <returns>Adresse IP publique du client</returns>
        public static string getAdresseIpPublique()
        {
            try
            {
                // Se connecte au site et télécharge les strings sur la page
                string adresseIp = new WebClient().DownloadString("https://api.ipify.org");
                // Vérifie si l'adresse IP a réussie à être récupérée
                if (adresseIp == "")
                {
                    return "Inconnue";
                }
                else
                {
                    return adresseIp;
                }
            }
            catch (Exception)
            {
                throw new Exception("La requête à l'API a échouée.");
            }

        }

        /// <summary>
        /// Permet de récupérer la ville selon l'adresse IP donné.
        /// </summary>
        /// <param name="adresseIp">L'adresse IP publique</param>
        /// <returns>La ville correspondante à l'adresse IP</returns>
        public static string getVilleByAdresseIp(string adresseIp)
        {
            dynamic reponse = Utilitaire.getJson($"https://ip.city/api.php?ip={ adresseIp }&key=50ca473f93670d50fb9ceb00b8a46632");
            return reponse.city.ToString();
        }

        /// <summary>
        /// Permet de récupérer la description métérologique du client.
        /// </summary>
        /// <returns>Description métérologique</returns>
        public static string getDescriptionMeteo()
        {
            string city = getVilleByAdresseIp(getAdresseIpPublique());
            dynamic response = Utilitaire.getJson($"https://api.openweathermap.org/data/2.5/weather?q={ city }&appid=cf608be0080551453ec5f6a1b1497fec&lang=fr&units=metric");
            return response.weather[0].description.ToString();
        }
    }
}
