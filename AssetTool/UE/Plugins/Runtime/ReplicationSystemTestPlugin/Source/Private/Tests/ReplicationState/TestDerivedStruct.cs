namespace AssetTool
{
    [JsonAsset("TestDerivedStruct_TestObject_Member")]
    public class UTestDerivedStruct_TestObject_Member : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestDerivedStruct_TestObject_Array")]
    public class UTestDerivedStruct_TestObject_Array : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestDerivedStructWithNetSerializerWithApply_TestObject_Member")]
    public class UTestDerivedStructWithNetSerializerWithApply_TestObject_Member : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestDerivedStructWithNetSerializerWithApply_TestObject_Array")]
    public class UTestDerivedStructWithNetSerializerWithApply_TestObject_Array : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestDerivedStructWithNetSerializerWithApply_Inherited_TestObject_Member")]
    public class UTestDerivedStructWithNetSerializerWithApply_Inherited_TestObject_Member : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestDerivedStructWithNetSerializerWithApply_Inherited_TestObject_Array")]
    public class UTestDerivedStructWithNetSerializerWithApply_Inherited_TestObject_Array : UReplicatedTestObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}