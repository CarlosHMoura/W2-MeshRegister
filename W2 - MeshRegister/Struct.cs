using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_RC2
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2560)]
    public STRUCT_RC[] File;
}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_RC
{
    // Atributos
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
    public byte[] Registro;
     

    public static string GetString(byte[] data)
    {
        if (data == null)
        {
            return "null";
        }
        return Encoding.UTF8.GetString(data).TrimEnd('\0');
    }
    public string Name
    {
        get => GetString(this.Registro);
        set => this.Registro = FromString(value, 52);
    }
    // Manipula strings
  
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

}

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_MESHTEXTURELIST2
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
    public STRUCT_MESHTEXTURELIST[] File;  
}



[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_MESHTEXTURELIST
{
    // Atributos
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
    public byte[] TextureName;  
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public byte[] TextureRegister; 

    public static string GetString(byte[] data)
    {
        if (data == null)
        {
            return "null";
        }
        return Encoding.UTF8.GetString(data).TrimEnd('\0');
    }
    public string Name
    {
        get => GetString(this.TextureName);
        set => this.TextureName = FromString(value, 254);
    }

    public char getRegister()
    {
        string value = GetString(TextureRegister).ToUpper();

        return value[1];
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

}



[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_UITEXTURELIST2
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public STRUCT_UITEXTURELIST[] File;
}



[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_UITEXTURELIST
{
    // Atributos
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
    public byte[] TextureName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public byte[] TextureRegister;

    public static string GetString(byte[] data)
    {
        if (data == null)
        {
            return "null";
        }
        return Encoding.UTF8.GetString(data).TrimEnd('\0');
    }
    public string Name
    {
        get => GetString(this.TextureName);
        set => this.TextureName = FromString(value, 254);
    }

    public char getRegister()
    {
        string value = GetString(TextureRegister).ToUpper();

        return value[1];
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
}




[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_ENVTEXTURELIST2
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public STRUCT_ENVTEXTURELIST[] File;
}



[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_ENVTEXTURELIST
{
    // Atributos
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
    public byte[] TextureName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public byte[] TextureRegister;

    public static string GetString(byte[] data)
    {
        if (data == null)
        {
            return "null";
        }
        return Encoding.UTF8.GetString(data).TrimEnd('\0');
    }
    public string Name
    {
        get => GetString(this.TextureName);
        set => this.TextureName = FromString(value, 254);
    }

    public char getRegister()
    {
        string value = GetString(TextureRegister).ToUpper();

        return value[1];
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

}





[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_EFFECTTEXTURELIST2
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public STRUCT_EFFECTTEXTURELIST[] File;
}



[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct STRUCT_EFFECTTEXTURELIST
{
    // Atributos
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
    public byte[] TextureName;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public byte[] TextureRegister;

    public static string GetString(byte[] data)
    {
        if (data == null)
        {
            return "null";
        }
        return Encoding.UTF8.GetString(data).TrimEnd('\0');
    }
    public string Name
    {
        get => GetString(this.TextureName);
        set => TextureName = FromString(value, 254);
    }

    public char getRegister()
    {
        string value = GetString(TextureRegister).ToUpper();

        return value[1];
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

}