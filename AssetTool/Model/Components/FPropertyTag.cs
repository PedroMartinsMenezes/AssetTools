namespace AssetTool
{
    public class FPropertyTag
    {
        public FName Type = new();
        public byte BoolVal;
        public FName Name = new();
        public FName StructName = new();
        public FName EnumName = new();
        public FName InnerType = new();
        public FName ValueType = new();
        public Int32 Size;
        public Int32 ArrayIndex;
        public Int64 SizeOffset;
        public FGuid StructGuid;
        public byte HasPropertyGuid;
        public FGuid PropertyGuid;

        #region Polymorphic Object
        public UInt32 Value_ObjectHandle;
        public FGuid Value_Guid;
        public FString Value_String;
        public Int32 Value_Int;
        #endregion
    }

    public static class FPropertyTagExt
    {
        public static void Write(this BinaryWriter writer, FPropertyTag item)
        {
            writer.Write(item.Name); //2879..2887
            if (item.Name.Value != "None")
            {
                //"ObjectProperty"
                writer.Write(item.Type); //2887..2895
                //4
                writer.Write(item.Size); //2895..2899
                //0
                writer.Write(item.ArrayIndex); //2899..2903

                writer.WriteExtra1(item);

                writer.Write(item.HasPropertyGuid); //2903..2904

                writer.WriteExtra2(item); //2904..2908
            }
        }

        public static void Read(this BinaryReader reader, List<FPropertyTag> list)
        {
            FPropertyTag item;
            // Load all stored properties, potentially skipping unknown ones.
            do
            {
                item = new FPropertyTag();
                //PropertyRecord << SA_VALUE(TEXT("Tag"), Tag);
                list.Add(reader.Read(item));
            }
            while (item.Name.Value != "None");
        }

        //PropertyRecord << SA_VALUE(TEXT("Tag"), Tag);
        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag item)
        {
            //"EditorData" | "Guid" | "Guid" | "None"
            //Slot << SA_ATTRIBUTE(TEXT("Name"), Tag.Name);
            reader.Read(item.Name);                     //2879..2887 | 2908..2916 | 2973..2981
            if (item.Name.Value != "None")
            {
                //Slot << SA_ATTRIBUTE(TEXT("Type"), Tag.Type);
                //"ObjectProperty" | "StructProperty"
                reader.Read(item.Type);                 //2887..2895 | 2916..2924 | 

                //Slot << SA_ATTRIBUTE(TEXT("Size"), Tag.Size);
                //4 | 16
                reader.Read(ref item.Size);             //2895..2899 | 2924..2928 |

                //Slot << SA_ATTRIBUTE(TEXT("ArrayIndex"), Tag.ArrayIndex);
                //0 | 0
                reader.Read(ref item.ArrayIndex);       //2899..2903 | 2928..2932 |

                //+0 | +24 | 
                reader.ReadExtra1(item);                //           | 2932..2956 |

                //Slot << SA_ATTRIBUTE(TEXT("HasPropertyGuid"), Tag.HasPropertyGuid);
                //+1 | +1
                reader.Read(ref item.HasPropertyGuid);  //2903..2904 | 2956..2957 |

                //Tag.SerializeTaggedProperty(ValueSlot, Property, DestAddress, DefaultsFromParent);
                reader.ReadExtra2(item);                //2904..2908 | 2957..2973 | ????..2985 pula pra void UStruct::Serialize(FArchive& Ar)
            }
            return item;
        }

        public static FPropertyTag ReadExtra1(this BinaryReader reader, FPropertyTag item)
        {
            if (item.Type.Number == 0)
            {
                if (item.Type.IsStructProperty())
                {
                    //Slot << SA_ATTRIBUTE(TEXT("StructName"), Tag.StructName);
                    //"" | "Guid"
                    reader.Read(item.Name);             //+8
                    //Slot << SA_ATTRIBUTE(TEXT("StructGuid"), Tag.StructGuid);
                    //"" | "0000"
                    reader.Read(ref item.StructGuid);   //+16
                }
                else if (item.Type.IsBoolProperty())
                {
                    reader.Read(ref item.BoolVal);      //+1
                }
                else if (item.Type.IsByteProperty())
                {
                    reader.Read(item.EnumName);         //+8
                }
                else if (item.Type.IsEnumProperty())
                {
                    reader.Read(item.EnumName);         //+8
                }
                else if (item.Type.IsArrayProperty())
                {
                    reader.Read(item.InnerType);        //+8
                }
                else if (item.Type.IsOptionalProperty())
                {
                    reader.Read(item.InnerType);        //+8
                }
                else if (item.Type.IsSetProperty())
                {
                    reader.Read(item.InnerType);        //+8
                }
                else if (item.Type.IsMapProperty())
                {
                    reader.Read(item.InnerType);        //+8
                    reader.Read(item.ValueType);        //+8
                }
            }
            return item;
        }

        public static void WriteExtra1(this BinaryWriter writer, FPropertyTag item)
        {
            if (item.Type.Number == 0)
            {
                if (item.Type.IsStructProperty())
                {
                    writer.Write(item.StructGuid);
                }
                else if (item.Type.IsBoolProperty())
                {
                    writer.Write(item.BoolVal);
                }
                else if (item.Type.IsByteProperty())
                {
                    writer.Write(item.EnumName);
                }
                else if (item.Type.IsEnumProperty())
                {
                    writer.Write(item.EnumName);
                }
                else if (item.Type.IsArrayProperty())
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.IsOptionalProperty())
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.IsSetProperty())
                {
                    writer.Write(item.InnerType);
                }
                else if (item.Type.IsMapProperty())
                {
                    writer.Write(item.InnerType);
                    writer.Write(item.ValueType);
                }
            }
        }

        public static FPropertyTag ReadExtra2(this BinaryReader reader, FPropertyTag item)
        {
            if (item.Name.Value == "Guid")
            {
                reader.Read(ref item.Value_Guid);
            }
            else if (item.Type.Value == "StrProperty")
            {
                reader.Read(item.Value_String);
            }
            else if (item.Type.Value == "IntProperty")
            {
                reader.Read(ref item.Value_Int);
            }
            else
            {
                reader.Read(ref item.Value_ObjectHandle);
            }
            return item;
        }

        public static void WriteExtra2(this BinaryWriter writer, FPropertyTag item)
        {
            if (item.Name.Value == "Guid")
            {
                writer.Write(item.Value_Guid);
            }
            else
            {
                writer.Write(item.Value_ObjectHandle);
            }
        }
    }
}
