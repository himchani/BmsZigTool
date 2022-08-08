using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleApp
{
    class DB_BmsProduction
    {
        public readonly string[] field_str =
        {
            "dateTime",             //0
            "completeDateTime",     //1
            "deliveryDateTime",     //2
            "type",                 //3
            "fwVersion",            //4
            "address",              //5
            "setID",                //6
            "deviceID",             //7
            "buyer",                //8
            "inBarcode",            //9
            "outBarcode",           //10
            "worker",               //11
            "test_5V",              //12
            "test_3V3",             //13
            "test_vcal1",           //14
            "test_vcal2",           //15
            "test_vcal3",           //16
            "test_vcal4",           //17
            "test_vcal5",           //18
            "test_vcal6",           //19
            "test_vcal7",           //20
            "test_vcal8",           //21
            "test_vcal9",           //22
            "test_vcal10",          //23
            "test_vcal11",          //24
            "test_vcal12",          //25
            "test_vcal13",          //26
            "test_vcal14",          //27
            "test_vcal15",          //28
            "test_vcal16",          //29
            "repairCnt",            //30
            "disposal",             //31
            "memo"                  //32
        };

        public DateTime start_time;
        public DateTime end_time;
        public int type;
        public string fw_version;
        public string address;
        public int set_id;
        public int device_id;
        public string buyer;
        public string inbarcode;
        public string outbarcode;
        public string worker;
        public double test_5V;
        public double test_3V3;
        public int test_vcal_1;
        public int test_vcal_2;
        public int test_vcal_3;
        public int test_vcal_4;
        public int test_vcal_5;
        public int test_vcal_6;
        public int test_vcal_7;
        public int test_vcal_8;
        public int test_vcal_9;
        public int test_vcal_10;
        public int test_vcal_11;
        public int test_vcal_12;
        public int test_vcal_13;
        public int test_vcal_14;
        public int test_vcal_15;
        public int test_vcal_16;
        public int repaire_cnt;
        public byte disposal;
        public string memo;
    }

}
