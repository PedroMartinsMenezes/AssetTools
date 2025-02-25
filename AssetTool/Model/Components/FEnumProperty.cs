﻿namespace AssetTool
{
    public class FEnumProperty : FProperty
    {
        public new const string TYPE_NAME = "EnumProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;
        public FName PropertyTypeName;
        public FField SingleField;

        [Location("void FEnumProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Value);
            SerializeSingleField(transfer);
            return this;
        }

        private void SerializeSingleField(Transfer transfer)
        {
            transfer.Move(ref PropertyTypeName);
            if (PropertyTypeName.IsFilled)
            {
                SingleField = SingleField ?? UStruct.GetNameToFieldClassMap(transfer, PropertyTypeName);
                SingleField.Move(transfer);
            }
        }
    }
}
