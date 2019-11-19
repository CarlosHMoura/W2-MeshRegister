using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W2___MixList
{
    public class Read
    {

        public static STRUCT_MESHTEXTURELIST[] g_pMeshTextureList { get;  set; }
        public static STRUCT_UITEXTURELIST[] g_UiTextureList { get; set; }
        public static STRUCT_RC[] g_pRC { get; set; }
        public static STRUCT_ENVTEXTURELIST[] g_pEnvTextureList { get; set; }
        public static STRUCT_EFFECTTEXTURELIST[] g_pEffectTextureList { get; set; }
        public static string currentPath = string.Empty;
        public static int FileID = -1;

        static Byte[] pKeyList = { 0, };
        
     

        public static T ReadFileStruct<T>(string Filename) where T : struct
        {
            return LoadFile<T>(FileToByteArray(Filename));
        }

        public static T LoadFile<T>(byte[] rawData) where T : struct
        {
            var pinnedRawData = GCHandle.Alloc(rawData, GCHandleType.Pinned);
            try
            {
                var pinnedRawDataPtr = pinnedRawData.AddrOfPinnedObject();
                return (T)Marshal.PtrToStructure(pinnedRawDataPtr, typeof(T));
            }
            finally
            {
                pinnedRawData.Free();
            }
        }
        public static string getString(byte[] data)
        {
            if (data == null)
            {
                throw new Exception("data == null");
            }
            return Encoding.UTF8.GetString(data).TrimEnd('\0');
        }
        public static byte getByte(string Value)
        {
            byte[] array = Encoding.ASCII.GetBytes(Value);

             

            return array[0];
        }
        public static byte[] getByteArray(string Value)
        {
            byte[] array = Encoding.ASCII.GetBytes(Value);



            return array;
        }
        public static byte[] FromString(string text, int size)
        {
            if (text == null)
            {
                throw new Exception("text == null");
            }

            byte[] buffer = Encoding.UTF8.GetBytes(text);

            Array.Resize(ref buffer, size);

            return buffer;
        }
        public static byte[] FileToByteArray(string fileName)
        {
            byte[] fileData = null;

            using (FileStream fs = File.OpenRead(fileName))
            {
                using (BinaryReader binaryReader = new BinaryReader(fs))
                {
                    fileData = binaryReader.ReadBytes((int)fs.Length);
                }
            }

             

            return fileData;
        }

         
       

        
            public static unsafe T ToStruct<T>(byte[] data) => ToStruct<T>(data, 0);
            public static unsafe T ToStruct<T>(byte[] data, int start)
            {
                fixed (byte* pBuffer = data)
                {
                    return (T)(Marshal.PtrToStructure(new IntPtr((void*)(&pBuffer[start])), typeof(T)));
                }
            }

            public static unsafe byte[] ToByteArray<T>(T str)
            {
                byte[] data = new byte[Marshal.SizeOf(str)];

                fixed (byte* buffer = data)
                {
                    Marshal.StructureToPtr(str, new IntPtr((void*)buffer), true);
                }

                return data;
            }

        // Carrega a MeshTextureList.bin
        public static void readMeshTextureList(string patch)
        {
            if (!File.Exists(patch) || patch == string.Empty)
            {
                MessageBox.Show("Arquivo não encontrado");
                return;
            }
            byte[] read = File.ReadAllBytes(patch);

            currentPath = patch;

            int Size = read.Length / Marshal.SizeOf<STRUCT_MESHTEXTURELIST>();

            g_pMeshTextureList = new STRUCT_MESHTEXTURELIST[Size];
 
            for (int i = 0; i < Size; i++)
            {
                g_pMeshTextureList[i] = new STRUCT_MESHTEXTURELIST();

            }
            for (int i = 0; i < Size; i++)
            {
                g_pMeshTextureList[i] = ToStruct<STRUCT_MESHTEXTURELIST>(read, i * 264);
            }
            FileID = 1;
            return;
        }

        // Carrega a UITextureList.bin
        public static void readUitextureList(string patch)
        {
            if (!File.Exists(patch) || patch == string.Empty)
            {
                MessageBox.Show("Arquivo não encontrado");
                return;
            }
            byte[] read = File.ReadAllBytes(patch);

            currentPath = patch;

            int size = read.Length / Marshal.SizeOf<STRUCT_UITEXTURELIST>();

            g_UiTextureList = new STRUCT_UITEXTURELIST[size];
 
            for (int i = 0; i < size; i++)
            {
                g_UiTextureList[i] = new STRUCT_UITEXTURELIST();

            }
            for (int i = 0; i < size; i++)
            {
                g_UiTextureList[i] = ToStruct<STRUCT_UITEXTURELIST>(read, i * 264);
            }
            FileID = 2;
        }

        // Carrega a EnvTextureList.bin
        public static void readEnvTextureList(string patch)
        {
            if (!File.Exists(patch) || patch == string.Empty)
            {
                MessageBox.Show("Arquivo não encontrado");
                return;
            }
            byte[] read = File.ReadAllBytes(patch);

            currentPath = patch;

            int size = read.Length / Marshal.SizeOf<STRUCT_ENVTEXTURELIST>();

            g_pEnvTextureList = new STRUCT_ENVTEXTURELIST[size];

    
            for (int i = 0; i < size; i++)
            {
                g_pEnvTextureList[i] = new STRUCT_ENVTEXTURELIST();

            }
            for (int i = 0; i < size; i++)
            {
                g_pEnvTextureList[i] = ToStruct<STRUCT_ENVTEXTURELIST>(read, i * 264);
            }
            FileID = 4;
        }


        // Carrega a EffectTextureList.bin
        public static void readEffectTextureList(string patch)
        {
            if (!File.Exists(patch) || patch == string.Empty)
            {
                MessageBox.Show("Arquivo não encontrado");
                return;
            }
            byte[] read = File.ReadAllBytes(patch);

            currentPath = patch;

            int size = read.Length / Marshal.SizeOf<STRUCT_EFFECTTEXTURELIST>();

            g_pEffectTextureList = new STRUCT_EFFECTTEXTURELIST[size];
 
            for (int i = 0; i < size; i++)
            {
                g_pEffectTextureList[i] = new STRUCT_EFFECTTEXTURELIST();

            }
            for (int i = 0; i < size; i++)
            {
                g_pEffectTextureList[i] = ToStruct<STRUCT_EFFECTTEXTURELIST>(read, i * 264);
            }
            FileID = 5;
        }
        // Carrega a RC.bin
        public static void readUIRC(string patch)
        {
            if (!File.Exists(patch) || patch == string.Empty)
            {
                MessageBox.Show("Arquivo não encontrado");
                return;
            }
            byte[] read = File.ReadAllBytes(patch);


            currentPath = patch;

            int nsize = read.Length / Marshal.SizeOf<STRUCT_RC>();

            g_pRC = new STRUCT_RC[nsize];
 
            for (int i = 0; i < nsize; i++)
                g_pRC[i] = new STRUCT_RC();


            for (int i = 0; i < g_pMeshTextureList.Length; i++)
                g_pRC[i] = ToStruct<STRUCT_RC>(read, i * 52);

            FileID = 3;
        }

   
        public static void SaveArquivo<T>(T bufffer)
        {
            try
            {
                if (currentPath == string.Empty)
                    return;

                byte[] arr = new byte[Marshal.SizeOf(bufffer)];

                IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf(bufffer));
                Marshal.StructureToPtr(bufffer, ptr, false);
                Marshal.Copy(ptr, arr, 0, Marshal.SizeOf(bufffer));
                Marshal.FreeHGlobal(ptr);


                File.WriteAllBytes(currentPath, arr);

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
