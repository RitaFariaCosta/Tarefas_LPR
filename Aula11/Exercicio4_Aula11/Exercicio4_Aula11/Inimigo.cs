using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Exercicio4_Aula11
{
    class Inimigo
    {
        public int vida;
        public int dano;

        public Inimigo()
        {
            dano = 1;
        }
        public void mover()
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
    
        public void atacarMario(Collider2D collider)
        {
            Mario mario = new Mario();
            if (collider.gameObject.layer == 15)
            {
                mario.vidas = mario.vidas - 1;
            }
        }
    }
}
