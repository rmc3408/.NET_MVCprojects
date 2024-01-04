import React, { useEffect, useState } from 'react'
import agent from '../../api/agent'
import { Product } from '../../types/Product'
import CatalogList from './CatalogList'

function Catalog() {
  const [products, setProducts] = useState<Product[]>([])

  useEffect(() => {
    agent.products.getProducts().then(data => setProducts(data))
  }, [])
  
  if (products.length === 0) {
    return <h1>Loading...</h1>
  }

  return (
    <>
      <h1>Catalog</h1>
      <CatalogList products={products} />
    </>
  )
}

export default Catalog