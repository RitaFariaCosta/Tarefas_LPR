using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Aula11
{
    public class Mario
    {
        public string nome;
        public string tamanho;
        public int vidas;

        public Mario()
        {
            nome = "Mário";
            tamanho = "pequeno";
        }
        public void andar()
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
            transform.position += movement * Time.deltaTime * Speed;

            //se andar
            if (Input.GetAxis("Horizontal") >= 0f)
            {
                anim.SetBool("walk", true);
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            if (Input.GetAxis("Horizontal") < 0f)
            {
                anim.SetBool("walk", true);
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
            if (Input.GetAxis("Horizontal") == 0f)
            {
                anim.SetBool("walk", false);
            }
        }
    
        public void pular()
        {
            if (Input.GetButtonDown("Jump") && isJumping == false)
            {
                rig.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
                anim.SetBool("jump", true);
                Console.WriteLine("MARIO PULOU");
            }
        }
        public void atacarInimigo(Collider2D collider)
        {
            Inimigo inimigo = new Inimigo();
            if (collider.gameObject.layer == 16)
            {
                inimigo.vida = inimigo.vida - 1;
            }

        }
        public void pegarCogumelo(Collider2D collider)
        {
            if (collider.gameObject.layer == 17)
            {
            tamanho = "Grande";
            vidas++;
            }
        }
    }
}
