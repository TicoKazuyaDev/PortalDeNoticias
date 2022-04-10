using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;
        public static List<Noticia> Noticias{
            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }
        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia{

                Id = 1,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Tiago Costa",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet"
            });

            noticias.Add(new Noticia{

                Id = 2,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Tiago Costa",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet"
            });

            noticias.Add(new Noticia{

                Id = 3,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Tiago Costa",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet"
            });

            noticias.Add(new Noticia{

                Id = 4,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Tiago Costa",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet"
            });

            noticias.Add(new Noticia{

                Id = 5,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Tiago Costa",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet"
            });

            noticias.Add(new Noticia{

                Id = 1,
                Titulo = "Lorem ipsum dolor sit amet",
                Autor = "Tiago Costa",
                Data = DateTime.Today,
                Conteudo = "Lorem ipsum dolor sit amet"
            });
        }
    }
}