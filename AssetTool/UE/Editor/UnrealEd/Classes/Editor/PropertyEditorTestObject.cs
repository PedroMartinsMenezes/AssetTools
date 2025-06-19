namespace AssetTool
{
    [JsonAsset("PropertyEditorTestInstancedObject")]
    public class UPropertyEditorTestInstancedObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FirstDerivedPropertyEditorTestObject")]
    public class UFirstDerivedPropertyEditorTestObject : UPropertyEditorTestInstancedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SecondDerivedPropertyEditorTestObject")]
    public class USecondDerivedPropertyEditorTestObject : UPropertyEditorTestInstancedObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PropertyEditorTestObject")]
    public class UPropertyEditorTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HideCategoriesBase")]
    public class UHideCategoriesBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ShowCategoriesTest")]
    public class UShowCategoriesTest : UHideCategoriesBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BlueprintPropertyTestObject")]
    public class UBlueprintPropertyTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("BlueprintPropertyContainerTestObject")]
    public class UBlueprintPropertyContainerTestObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestSparseClassDataBase")]
    public class UTestSparseClassDataBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestSparseClassData")]
    public class UTestSparseClassData : UTestSparseClassDataBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PropertyEditorTestActor")]
    public class APropertyEditorTestActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PropertyEditorRowGeneratorTest")]
    public class UPropertyEditorRowGeneratorTest : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}