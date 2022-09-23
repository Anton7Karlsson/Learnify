import React, { useEffect, useState } from "react";
import { Table } from "antd";
import * as FaIcons from "react-icons/fa";
import agent from "../actions/agent";
import { Basket } from "../models/basket";
import { Course } from "../models/course";

const BasketPage = () => {
  const [items, setItems] = useState<Basket>();

  useEffect(() => {
    agent.Baskets.get().then((response) => {
      setItems(response);
    });
  }, []);

  const columns = [
    {
      title: "Image",
      dataIndex: "image",
      key: "image",
      render: (url: string) => {
        return <img width="100px" src={url} alt={url} />;
      }
    },
    {
      title: "Title",
      dataIndex: "title",
      key: "title",
    },
    {
      title: "Price",
      dataIndex: "price",
      key: "price",
    },
    {
      title: "Instructor",
      key: "instructor",
      dataIndex: "instructor",
    },
    {
      title: "Action",
      key: "action",
      render: (item: Course) => (
        <div>
            <FaIcons.FaTrash />
        </div>
      ),
    },
  ];
  

  <Table columns={columns} dataSource={items?.items} />;


  return (
    <>
      <h1>{items?.clientId}</h1>
    </>
  );
};

export default BasketPage;
