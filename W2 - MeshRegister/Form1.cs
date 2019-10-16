using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace W2___MixList
{
    public partial class Form1 : Form
    {
        public int IndexOfStruct = 0;
        public int Index = -1;
        public Form1()
        {
            InitializeComponent();

            Read.g_pMeshTextureList = new STRUCT_MESHTEXTURELIST[2048];
            Read.g_pRC = new STRUCT_RC[2048];



            
        }
        public bool isRCBIN = false;
         

        

        public static int[]  Count = new int[100];
        private void Form1_Load(object sender, EventArgs e)
        {
 
 
        }

        private void lbNpc_SelectedIndexChanged(object sender, EventArgs e) // Ler dados do arquivo
        {
            Index = meshList.SelectedIndex;


            if (Index == -1)
                return;

            if (Read.FileID == 5)
            {
                textura.Text = Read.g_pEffectTextureList[Index].Name;
                registro.Text = "" + Read.g_pEffectTextureList[Index].getRegister();
            }
            if (Read.FileID == 4)
            {
                textura.Text = Read.g_pEnvTextureList[Index].Name;
                registro.Text = "" + Read.g_pEnvTextureList[Index].getRegister();
            }
            if (Read.FileID == 3)
            {
                textura.Text = Read.g_pRC[Index].Name;
                registro.Text = "";
                return;
            }
            if (Read.FileID == 2)
            {
                textura.Text = Read.g_UiTextureList[Index].Name;
                registro.Text = "" + Read.g_UiTextureList[Index].getRegister();
            }
            if (Read.FileID == 1)
            {
                textura.Text = Read.g_pMeshTextureList[Index].Name;
                registro.Text = "" + Read.g_pMeshTextureList[Index].getRegister();
            }




        }

        private void button1_Click(object sender, EventArgs e) // Salvar dados e escrever arquivo
        {
            if (Index == -1)
                return;
            registro.Text.ToUpper();



            if (Read.FileID == 1 || Read.FileID == 2)
            {
                if (registro.Text != "N" && registro.Text != "C" && registro.Text != "A" &&
                    registro.Text != "n" && registro.Text != "c" && registro.Text != "a")
                {
                    MessageBox.Show("Registro permite apenas: \n\n(A) para camada alpha\n(C) ???\n(N) normal mesh texture");
                    return;
                }


                if (Read.FileID == 2)
                {
                    Read.g_UiTextureList[Index].TextureRegister[1] = Read.getByte(registro.Text.ToUpper());
                    Read.g_UiTextureList[Index].TextureName = Read.FromString(textura.Text, 254);
                    MessageBox.Show("[" + Index + "]" + " UI Textura: " + Read.g_UiTextureList[Index].Name + " foi alterada com sucesso");
                }
                else
                {
                    Read.g_pMeshTextureList[Index].TextureRegister[1] = Read.getByte(registro.Text.ToUpper());
                    Read.g_pMeshTextureList[Index].TextureName = Read.FromString(textura.Text, 254);
                    MessageBox.Show("[" + Index + "]" + " Textura: " + Read.g_pMeshTextureList[Index].Name + " foi alterada com sucesso");
                }

            }
            else if(Read.FileID == 3)
            {
                Read.g_pRC[Index].Registro = Read.FromString(textura.Text, 52);

                MessageBox.Show("[" + Index + "]" + " RC: " + Read.g_pRC[Index].Name + " foi alterada com sucesso");
            }
            else if (Read.FileID == 4)
            {
                Read.g_pEnvTextureList[Index].TextureRegister[1] = Read.getByte(registro.Text.ToUpper());
                Read.g_pEnvTextureList[Index].TextureName = Read.FromString(textura.Text, 254);
                MessageBox.Show("[" + Index + "]" + " Textura: " + Read.g_pEnvTextureList[Index].Name + " foi alterada com sucesso");
            }
            else if (Read.FileID == 5)
            {
                Read.g_pEffectTextureList[Index].TextureRegister[1] = Read.getByte(registro.Text.ToUpper());
                Read.g_pEffectTextureList[Index].TextureName = Read.FromString(textura.Text, 254);
                MessageBox.Show("[" + Index + "]" + " Textura: " + Read.g_pEffectTextureList[Index].Name + " foi alterada com sucesso");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var index = meshList.SelectedIndex;
 
        }
 
        public void Reload_RC()
        {
            textura.Text = string.Empty;
            registro.Text = string.Empty;
            registro.Enabled = false;
            meshList.Items.Clear();

             

            for (int i = 0; i < 512; i++)
                meshList.Items.Add("[" + i + "]  " + Read.g_pRC[i].Name);
        }
        public void ReloadUitextureList()
        {
            textura.Text = string.Empty;
            registro.Text = string.Empty;
            registro.Enabled = true;
            meshList.Items.Clear();
           

            
            for (int i = 0; i < 512; i++)
                meshList.Items.Add("[" + i + "]  " + Read.g_UiTextureList[i].Name);
        }
        public void ReloadMeshTextureList()
        {
            textura.Text = string.Empty;
            registro.Text = string.Empty;
            registro.Enabled = true;
            meshList.Items.Clear();
            

            
            for (int i = 0; i < 2048; i++)
                meshList.Items.Add("[" + i + "]  " + Read.g_pMeshTextureList[i].Name);
        }



        public void ReloadEffectTextureList()
        {
            textura.Text = string.Empty;
            registro.Text = string.Empty;
            registro.Enabled = true;
            meshList.Items.Clear();



            for (int i = 0; i < 512; i++)
                meshList.Items.Add("[" + i + "]  " + Read.g_pEffectTextureList[i].Name);
        }
        public void ReloadEnvTextureList()
        {
            textura.Text = string.Empty;
            registro.Text = string.Empty;
            registro.Enabled = true;
            meshList.Items.Clear();



            for (int i = 0; i < 512; i++)
                meshList.Items.Add("[" + i + "]  " + Read.g_pEnvTextureList[i].Name);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textura.Text = string.Empty;
            registro.Text = string.Empty;
        }

 

        private void registro_TextChanged(object sender, EventArgs e)
        {
            registro.Text.ToUpper();
        }

        private void registro_Leave(object sender, EventArgs e)
        {
            registro.Text.ToUpper();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(Read.FileID == 1)
            {
                STRUCT_MESHTEXTURELIST2 mesh = new STRUCT_MESHTEXTURELIST2();
                mesh.File = Read.g_pMeshTextureList;
                Read.SaveArquivo(mesh);
            }
            if (Read.FileID == 2)
            {
                STRUCT_UITEXTURELIST2 ui = new STRUCT_UITEXTURELIST2();
                ui.File = Read.g_UiTextureList;
                Read.SaveArquivo(ui);
            }
            if (Read.FileID == 3)
            {
                STRUCT_RC2 rc = new STRUCT_RC2();
                rc.File = Read.g_pRC;
                Read.SaveArquivo(rc);
            }

            if (Read.FileID == 4)
            {
                STRUCT_ENVTEXTURELIST2 env = new STRUCT_ENVTEXTURELIST2();
                env.File = Read.g_pEnvTextureList;
                Read.SaveArquivo(env);
            }

            if (Read.FileID == 5)
            {
                STRUCT_EFFECTTEXTURELIST2 effect = new STRUCT_EFFECTTEXTURELIST2();
                effect.File = Read.g_pEffectTextureList;
                Read.SaveArquivo(effect);
            }

            MessageBox.Show("Arquivo "+ Read.currentPath+" salvo com sucesso");
        }

   
        private void button5_Click_1(object sender, EventArgs e)
        {
            isRCBIN = false;
            dirPatch.Text = Read.currentPath;
            Read.readUitextureList($"./UI/UITextureListN.bin");
            ReloadUitextureList();
            dirPatch.Text = Read.currentPath;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            isRCBIN = false;
            dirPatch.Text = Read.currentPath;
            Read.readMeshTextureList($"./Mesh/MeshtextureList.bin");
            ReloadMeshTextureList();
            dirPatch.Text = Read.currentPath;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            isRCBIN = true;
            dirPatch.Text = Read.currentPath;
            Read.readUIRC($"./UI/RC.bin");
            
            Reload_RC();
            dirPatch.Text = Read.currentPath;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isRCBIN = false;
            dirPatch.Text = Read.currentPath;
            Read.readEnvTextureList($"./Env/EnvTextureList3.bin");
            ReloadEnvTextureList();
            dirPatch.Text = Read.currentPath;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isRCBIN = false;
            
            Read.readEffectTextureList($"./Effect/EffectTextureList.bin");
            ReloadEffectTextureList();

            dirPatch.Text = Read.currentPath;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
