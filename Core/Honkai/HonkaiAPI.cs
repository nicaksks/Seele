using Newtonsoft.Json;
using SeeleAPI.Model.Honkai;

namespace SeeleAPI.Core.HonkaiAPI
{
    public class HonkaiAPI
    {
        private string uid;
        private string id;
        private string cookie;
        private string token;
        private string ds;

        public HonkaiAPI(string uid, string id, string cookie, string token, string ds)
        {
            this.uid = uid;
            this.id = id;
            this.cookie = cookie;
            this.token = token;
            this.ds = ds;
        }
        public async Task<Data> Request()
        {
            const string version = "1.5.0";
            const string type = "5";
            const string lang = "en-us";

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36 OPR/97.0.0.0");
            httpClient.DefaultRequestHeaders.Add("x-rpc-app_version", version);
            httpClient.DefaultRequestHeaders.Add("x-rpc-client_type", type);
            httpClient.DefaultRequestHeaders.Add("x-rpc-language", lang);
            httpClient.DefaultRequestHeaders.Add("DS", ds);
            httpClient.DefaultRequestHeaders.Add("Cookie", $"account_id={id}; cookie_token={cookie}; ltoken={token}; ltuid={id}; mi18nLang={lang}");

            var response = await httpClient.GetAsync($"https://bbs-api-os.hoyolab.com/game_record/honkai3rd/api/index?server=usa01&role_id={uid}");
            var content = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<Root>(content);

            return data.data;
        }
    }
}
