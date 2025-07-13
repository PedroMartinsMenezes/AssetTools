namespace AssetTool
{
    [JsonAsset("TestReplicationStateDescriptor_TestClass")]
    public class UTestReplicationStateDescriptor_TestClass : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithInheritance")]
    public class UTestReplicationStateDescriptor_TestClassWithInheritance : UTestReplicationStateDescriptor_TestClass
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithNonReplicatedData")]
    public class UTestReplicationStateDescriptor_TestClassWithNonReplicatedData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithReplicatedStruct")]
    public class UTestReplicationStateDescriptor_TestClassWithReplicatedStruct : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithTArray")]
    public class UTestReplicationStateDescriptor_TestClassWithTArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithStructWithTArray")]
    public class UTestReplicationStateDescriptor_TestClassWithStructWithTArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCArray")]
    public class UTestReplicationStateDescriptor_TestClassWithCArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithStructWithCArray")]
    public class UTestReplicationStateDescriptor_TestClassWithStructWithCArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithEnums")]
    public class UTestReplicationStateDescriptor_TestClassWithEnums : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRoleAndRemoteRole")]
    public class UTestReplicationStateDescriptor_TestClassWithRoleAndRemoteRole : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithManyRoles")]
    public class UTestReplicationStateDescriptor_TestClassWithManyRoles : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRPCs")]
    public class UTestReplicationStateDescriptor_TestClassWithRPCs : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_InheritedTestClassWithRPCs")]
    public class UTestReplicationStateDescriptor_InheritedTestClassWithRPCs : UTestReplicationStateDescriptor_TestClassWithRPCs
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRef")]
    public class UTestReplicationStateDescriptor_TestClassWithRef : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRefInStruct")]
    public class UTestReplicationStateDescriptor_TestClassWithRefInStruct : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRefInStructWithNestedCArray")]
    public class UTestReplicationStateDescriptor_TestClassWithRefInStructWithNestedCArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRefInStructWithNestedTArray")]
    public class UTestReplicationStateDescriptor_TestClassWithRefInStructWithNestedTArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRefInCArray")]
    public class UTestReplicationStateDescriptor_TestClassWithRefInCArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRefInTArray")]
    public class UTestReplicationStateDescriptor_TestClassWithRefInTArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRefInStructCArray")]
    public class UTestReplicationStateDescriptor_TestClassWithRefInStructCArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithRefInStructTArray")]
    public class UTestReplicationStateDescriptor_TestClassWithRefInStructTArray : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestFunctionWithPODParameters")]
    public class UTestReplicationStateDescriptor_TestFunctionWithPODParameters : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestFunctionWithNonPODParameters")]
    public class UTestReplicationStateDescriptor_TestFunctionWithNonPODParameters : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestFunctionWithNotReplicatedNonPODParameters")]
    public class UTestReplicationStateDescriptor_TestFunctionWithNotReplicatedNonPODParameters : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCondition_InitialOnly")]
    public class UTestReplicationStateDescriptor_TestClassWithCondition_InitialOnly : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCondition_ToOwner")]
    public class UTestReplicationStateDescriptor_TestClassWithCondition_ToOwner : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCondition_SkipOwner")]
    public class UTestReplicationStateDescriptor_TestClassWithCondition_SkipOwner : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCondition_InitialOrOwner")]
    public class UTestReplicationStateDescriptor_TestClassWithCondition_InitialOrOwner : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCondition_LifetimeConditionals")]
    public class UTestReplicationStateDescriptor_TestClassWithCondition_LifetimeConditionals : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCondition_CustomConditionals")]
    public class UTestReplicationStateDescriptor_TestClassWithCondition_CustomConditionals : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithCondition_Never")]
    public class UTestReplicationStateDescriptor_TestClassWithCondition_Never : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithNotFullyReplicatedStructAndArrays")]
    public class UTestReplicationStateDescriptor_TestClassWithNotFullyReplicatedStructAndArrays : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithFullyReplicatedStructAndArrays")]
    public class UTestReplicationStateDescriptor_TestClassWithFullyReplicatedStructAndArrays : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TestReplicationStateDescriptor_TestClassWithFieldPathProperty")]
    public class UTestReplicationStateDescriptor_TestClassWithFieldPathProperty : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}