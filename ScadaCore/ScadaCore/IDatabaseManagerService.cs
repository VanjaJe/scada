﻿using System.Collections.Generic;
using System.ServiceModel;

namespace ScadaCore
{
    [ServiceContract]
    public interface IDatabaseManagerService
    {
        [OperationContract]
        bool Registration(string username, string password);
        [OperationContract]
        string Login(string username, string password);
        [OperationContract]
        bool LogOut(string token);
        [OperationContract]
        bool DatabaseEmpty();
        [OperationContract]
        void StopTagThreads();
        [OperationContract]
        bool CheckTagName(string name);
        [OperationContract]
        bool AddDigitalInputTag(string name, string description, string address, int driver, int scanTime, bool scanOn);
        [OperationContract]
        bool AddAnalogInputTag(string name, string description, string address, int driver, int scanTime, bool scanOn, int lowLimit, int hightLimit, string units);
        [OperationContract]
        bool AddDigitalOutputTag(string name, string description, string address, int initialValue);
        [OperationContract]
        bool AddAnalogOutputTag(string name, string description, string address, int initialValue, int lowLimit, int hightLimit, string units);
        [OperationContract]
        bool AddAnalogAlarm(string tagName, int id, int type, int priority, double edgeValue, string units);
        [OperationContract]
        bool CheckAlarmId(int id);
        [OperationContract]
        bool TurnOnScan(string name);
        [OperationContract]
        bool TurnOffScan(string name);
        [OperationContract]
        bool RemoveInputTag(string name);
        [OperationContract]
        bool RemoveAlarm(int id);
        [OperationContract]
        bool RemoveOutputTag(string name);
        [OperationContract]
        Dictionary<string, int> GetDigitalOutputTags();
        [OperationContract]
        Dictionary<string, int> GetAnalogOutputTags();
        [OperationContract]
        bool ChangeValueDigitalOutputTag(string name, int newValue);
        [OperationContract]
        bool ChangeValueAnalogOutputTag(string name, int newValue);
        [OperationContract]
        bool ContainsAnalogInputTag(string name);
        [OperationContract]
        bool ContainsInputTag(string name);
        [OperationContract]
        bool ContainsOutputTag(string name);
        [OperationContract]
        void ReadFromConfig();
    }
}
