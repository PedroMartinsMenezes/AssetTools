namespace AssetTool
{
    [JsonAsset("PyTestStructLibrary")]
    public class UPyTestStructLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PyTestObject")]
    public class UPyTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PyTestChildObject")]
    public class UPyTestChildObject : UPyTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LegacyPyTestObject")]
    public class UDEPRECATED_LegacyPyTestObject : UPyTestObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PyTestObjectLibrary")]
    public class UPyTestObjectLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PyTestStructDelegate")]
    public class UPyTestStructDelegate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PyTestVectorDelegate")]
    public class UPyTestVectorDelegate : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PyTestTypeHint")]
    public class UPyTestTypeHint : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}