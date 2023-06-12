using duckling_aleatory_cats.MODEL;
using duckling_aleatory_cats.DAL.DBContext;
using System.Text.Json;



namespace duckling_aleatory_cats.BLL
{
    public class CatRepository {

        public List<TbCat> GetCatsFromUser(int id)
        {
            using (var dbContext = new DbContext())
            {
                var cats = dbContext.TbUserCats
                    .Where(uc => uc.IdUser == id)
                    .Join(
                        dbContext.TbCats,
                        uc => uc.IdCat,
                        c => c.IdCat,
                        (uc, c) => c
                    )
                    .ToList();

                return cats;
            }
        }

        public TbCat AddCat(TbCat _tbcat)
        {
  
                using (var dbContext = new DbContext())
                {
                    dbContext.Add(_tbcat);
                dbContext.SaveChanges();

                }

            return _tbcat;
        }

        public TbCat AddUserCat(TbUser _tbuser, TbCat _tbcat)
        {

            using (var dbContext = new DbContext())
            {
                TbUserCat tbusercat = new TbUserCat();
             

                tbusercat.IdUser = _tbuser.IdUser;
                tbusercat.IdCat = _tbcat.IdCat;
                dbContext.Add(tbusercat);
                dbContext.SaveChanges();

            }

            return _tbcat;
        }

        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<string> GetCatImageUrl()
        {
            string apiUrl = "https://api.thecatapi.com/v1/images/search";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                var catData = JsonDocument.Parse(responseBody).RootElement;
                if (catData.ValueKind == JsonValueKind.Array && catData.GetArrayLength() > 0)
                {
                    string catImageUrl = catData[0].GetProperty("url").GetString();

                    return catImageUrl;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erro ao acessar a API: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
            }

            return null;
        }
    }
}
